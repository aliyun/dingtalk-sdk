<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponseBody\extension\cardContactInfo;
use AlibabaCloud\Tea\Model;

class extension extends Model
{
    /**
     * @description 企业是否认证
     *
     * @var bool
     */
    public $orgAuthed;

    /**
     * @description 企业认证等级
     *
     * @var int
     */
    public $orgAuthLevel;

    /**
     * @description 企业corpId
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 企业LOGO
     *
     * @var string
     */
    public $orgLogo;

    /**
     * @description 视频信息
     *
     * @var string
     */
    public $videoMediaId;

    /**
     * @description 联系信息
     *
     * @var cardContactInfo
     */
    public $cardContactInfo;
    protected $_name = [
        'orgAuthed'       => 'orgAuthed',
        'orgAuthLevel'    => 'orgAuthLevel',
        'corpId'          => 'corpId',
        'orgLogo'         => 'orgLogo',
        'videoMediaId'    => 'videoMediaId',
        'cardContactInfo' => 'cardContactInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->orgAuthed) {
            $res['orgAuthed'] = $this->orgAuthed;
        }
        if (null !== $this->orgAuthLevel) {
            $res['orgAuthLevel'] = $this->orgAuthLevel;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->orgLogo) {
            $res['orgLogo'] = $this->orgLogo;
        }
        if (null !== $this->videoMediaId) {
            $res['videoMediaId'] = $this->videoMediaId;
        }
        if (null !== $this->cardContactInfo) {
            $res['cardContactInfo'] = null !== $this->cardContactInfo ? $this->cardContactInfo->toMap() : null;
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
        if (isset($map['orgAuthed'])) {
            $model->orgAuthed = $map['orgAuthed'];
        }
        if (isset($map['orgAuthLevel'])) {
            $model->orgAuthLevel = $map['orgAuthLevel'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['orgLogo'])) {
            $model->orgLogo = $map['orgLogo'];
        }
        if (isset($map['videoMediaId'])) {
            $model->videoMediaId = $map['videoMediaId'];
        }
        if (isset($map['cardContactInfo'])) {
            $model->cardContactInfo = cardContactInfo::fromMap($map['cardContactInfo']);
        }

        return $model;
    }
}
