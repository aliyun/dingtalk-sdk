<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetMediaCerficateRequest extends Model
{
    /**
     * @description 视频的文件名称,必须带扩展名,支持的扩展名参考:https://help.aliyun.com/document_detail/55396.htm?spm=a2c4g.11186623.2.11.2d385d4aG2IkCZ#title-j7o-gr4-c7a
     *
     * @var string
     */
    public $fileName;

    /**
     * @description 入驻账号Id(请联系钉钉接口同学获取)
     *
     * @var string
     */
    public $mcnId;

    /**
     * @description 如果传入该值，表示续订该mediaId对应的上传凭证 ;否则将视为新建一个视频上传连接和凭证
     *
     * @var string
     */
    public $mediaId;

    /**
     * @description 视频介绍
     *
     * @var string
     */
    public $mediaIntroduction;

    /**
     * @description 视频的标题
     *
     * @var string
     */
    public $mediaTitle;

    /**
     * @description 自定义视频封面的URL地址
     *
     * @var string
     */
    public $thumbUrl;

    /**
     * @description 操作人的用户id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'fileName'          => 'fileName',
        'mcnId'             => 'mcnId',
        'mediaId'           => 'mediaId',
        'mediaIntroduction' => 'mediaIntroduction',
        'mediaTitle'        => 'mediaTitle',
        'thumbUrl'          => 'thumbUrl',
        'userId'            => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->mcnId) {
            $res['mcnId'] = $this->mcnId;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->mediaIntroduction) {
            $res['mediaIntroduction'] = $this->mediaIntroduction;
        }
        if (null !== $this->mediaTitle) {
            $res['mediaTitle'] = $this->mediaTitle;
        }
        if (null !== $this->thumbUrl) {
            $res['thumbUrl'] = $this->thumbUrl;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetMediaCerficateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['mcnId'])) {
            $model->mcnId = $map['mcnId'];
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['mediaIntroduction'])) {
            $model->mediaIntroduction = $map['mediaIntroduction'];
        }
        if (isset($map['mediaTitle'])) {
            $model->mediaTitle = $map['mediaTitle'];
        }
        if (isset($map['thumbUrl'])) {
            $model->thumbUrl = $map['thumbUrl'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
