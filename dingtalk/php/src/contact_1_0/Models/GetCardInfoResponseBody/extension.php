<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponseBody\extension\cardContactInfo;
use AlibabaCloud\Tea\Model;

class extension extends Model
{
    /**
     * @description 联系信息
     *
     * @var cardContactInfo
     */
    public $cardContactInfo;

    /**
     * @description 企业corpId
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 拍名片部门
     *
     * @var string
     */
    public $department;

    /**
     * @description 企业是否认证
     *
     * @var bool
     */
    public $orgAuthed;

    /**
     * @description 企业LOGO
     *
     * @var string
     */
    public $orgLogo;

    /**
     * @description 拍名片图片链接
     *
     * @var string
     */
    public $originCardUrl;

    /**
     * @description 分享文案
     *
     * @var string
     */
    public $shareContent;

    /**
     * @description 视频缩略图
     *
     * @var string
     */
    public $thumbnailUrl;

    /**
     * @description 视频文件名称
     *
     * @var string
     */
    public $videoFileName;

    /**
     * @description 视频标题
     *
     * @var string
     */
    public $videoTitle;

    /**
     * @description 视频链接
     *
     * @var string
     */
    public $videoUrl;
    protected $_name = [
        'cardContactInfo' => 'cardContactInfo',
        'corpId'          => 'corpId',
        'department'      => 'department',
        'orgAuthed'       => 'orgAuthed',
        'orgLogo'         => 'orgLogo',
        'originCardUrl'   => 'originCardUrl',
        'shareContent'    => 'shareContent',
        'thumbnailUrl'    => 'thumbnailUrl',
        'videoFileName'   => 'videoFileName',
        'videoTitle'      => 'videoTitle',
        'videoUrl'        => 'videoUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardContactInfo) {
            $res['cardContactInfo'] = null !== $this->cardContactInfo ? $this->cardContactInfo->toMap() : null;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->department) {
            $res['department'] = $this->department;
        }
        if (null !== $this->orgAuthed) {
            $res['orgAuthed'] = $this->orgAuthed;
        }
        if (null !== $this->orgLogo) {
            $res['orgLogo'] = $this->orgLogo;
        }
        if (null !== $this->originCardUrl) {
            $res['originCardUrl'] = $this->originCardUrl;
        }
        if (null !== $this->shareContent) {
            $res['shareContent'] = $this->shareContent;
        }
        if (null !== $this->thumbnailUrl) {
            $res['thumbnailUrl'] = $this->thumbnailUrl;
        }
        if (null !== $this->videoFileName) {
            $res['videoFileName'] = $this->videoFileName;
        }
        if (null !== $this->videoTitle) {
            $res['videoTitle'] = $this->videoTitle;
        }
        if (null !== $this->videoUrl) {
            $res['videoUrl'] = $this->videoUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return extension
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardContactInfo'])) {
            $model->cardContactInfo = cardContactInfo::fromMap($map['cardContactInfo']);
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['department'])) {
            $model->department = $map['department'];
        }
        if (isset($map['orgAuthed'])) {
            $model->orgAuthed = $map['orgAuthed'];
        }
        if (isset($map['orgLogo'])) {
            $model->orgLogo = $map['orgLogo'];
        }
        if (isset($map['originCardUrl'])) {
            $model->originCardUrl = $map['originCardUrl'];
        }
        if (isset($map['shareContent'])) {
            $model->shareContent = $map['shareContent'];
        }
        if (isset($map['thumbnailUrl'])) {
            $model->thumbnailUrl = $map['thumbnailUrl'];
        }
        if (isset($map['videoFileName'])) {
            $model->videoFileName = $map['videoFileName'];
        }
        if (isset($map['videoTitle'])) {
            $model->videoTitle = $map['videoTitle'];
        }
        if (isset($map['videoUrl'])) {
            $model->videoUrl = $map['videoUrl'];
        }

        return $model;
    }
}
