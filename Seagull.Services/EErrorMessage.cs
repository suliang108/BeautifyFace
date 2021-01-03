using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seagull.Services
{
    public enum EErrorMessage
    {
        #region 当前 API 特有的 ERROR_MESSAGE

        /// <summary>
        /// 参数 <param> 对应的图像无法正确解析，有可能不是一个图像文件、或有数据破损。
        /// </summary>
        IMAGE_ERROR_UNSUPPORTED_FORMAT,

        /// <summary>
        /// 参数 <param> 对应的客户上传的图像像素尺寸太大或太小，图片要求请参照本 API 描述。<param> 对应图像太大的那个参数的名称。
        /// </summary>
        INVALID_IMAGE_SIZE,

        /// <summary>
        /// 无法从参数 <param> 对应的 image_url 下载图片，图片 URL 错误或者无效。
        /// </summary>
        INVALID_IMAGE_URL,

        /// <summary>
        /// 参数<param>对应的客户上传的图像文件太大。本 API 要求图片文件大小不超过 2 MB
        /// </summary>
        IMAGE_FILE_TOO_LARGE,

        /// <summary>
        /// 参数<param>对应的图片未检测到人脸。
        /// </summary>
        NO_FACE_FOUND,

        /// <summary>
        /// 上传的图片人脸不符合要求。已知情况：
        /// </summary>
        BAD_FACE,

        /// <summary>
        /// 传入的人脸框格式不符合要求，或者人脸框位于图片外
        /// </summary>
        INVALID_RECTANGLE,

        /// <summary>
        /// 缺少必选参数
        /// </summary>
        MISSING_ARGUMENTS,

        /// <summary>
        /// 下载图片超时。
        /// </summary>
        IMAGE_DOWNLOAD_TIMEOUT,

        #endregion

        #region 通用的ERROR_MESSAGE

        /// <summary>
        /// api_key没有调用本API的权限，具体原因为：用户自己禁止该api_key调用、管理员禁止该api_key调用、由于账户余额不足禁止调用。
        /// Denied by Client（用户自己禁止该api_key调用）
        /// Denied by Admin（管理员禁止该api_key调用）
        /// Insufficient Account Balance（由于账户余额不足禁止调用）
        /// </summary>
        AUTHENTICATION_ERROR,

        /// <summary>
        /// 并发数超过限制。
        /// 注：这里的并发控制数超出限制，是指该API Key的QPS已经达到上限。如需要提高API Key的QPS配额请查看价格方案或者联系我们。
        /// </summary>
        CONCURRENCY_LIMIT_EXCEEDED,

        /// <summary>
        /// 某个参数解析出错（比如必须是数字，但是输入的是非数字字符串; 或者长度过长，etc.）
        /// </summary>
        BAD_ARGUMENTS,

        /// <summary>
        /// 同时传入了要求是二选一或多选一的参数。如有特殊说明则不返回此错误。
        /// </summary>
        COEXISTENCE_ARGUMENTS,

        /// <summary>
        /// 客户发送的请求大小超过了2MB限制。该错误的返回格式为纯文本，不是json格式。
        /// </summary>
        Request_Entity_Too_Large,

        /// <summary>
        /// 所调用的API不存在。
        /// </summary>
        API_NOT_FOUND,

        /// <summary>
        /// 服务器内部错误，当此类错误发生时请再次请求，如果持续出现此类错误，请及时联系技术支持团队。
        /// </summary>
        INTERNAL_ERROR,

        #endregion
    }
}
