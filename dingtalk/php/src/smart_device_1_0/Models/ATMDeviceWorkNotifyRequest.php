<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models;

use AlibabaCloud\Tea\Model;

class ATMDeviceWorkNotifyRequest extends Model
{
    /**
     * @var string
     */
    public $creatorCorpId;

    /**
     * @var string
     */
    public $creatorUnionId;

    /**
     * @var string
     */
    public $notifyType;

    /**
     * @var string
     */
    public $paramContent;

    /**
     * @var string
     */
    public $targetUrl;
    protected $_name = [
        'creatorCorpId' => 'creatorCorpId',
        'creatorUnionId' => 'creatorUnionId',
        'notifyType' => 'notifyType',
        'paramContent' => 'paramContent',
        'targetUrl' => 'targetUrl',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorCorpId) {
            $res['creatorCorpId'] = $this->creatorCorpId;
        }
        if (null !== $this->creatorUnionId) {
            $res['creatorUnionId'] = $this->creatorUnionId;
        }
        if (null !== $this->notifyType) {
            $res['notifyType'] = $this->notifyType;
        }
        if (null !== $this->paramContent) {
            $res['paramContent'] = $this->paramContent;
        }
        if (null !== $this->targetUrl) {
            $res['targetUrl'] = $this->targetUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ATMDeviceWorkNotifyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creatorCorpId'])) {
            $model->creatorCorpId = $map['creatorCorpId'];
        }
        if (isset($map['creatorUnionId'])) {
            $model->creatorUnionId = $map['creatorUnionId'];
        }
        if (isset($map['notifyType'])) {
            $model->notifyType = $map['notifyType'];
        }
        if (isset($map['paramContent'])) {
            $model->paramContent = $map['paramContent'];
        }
        if (isset($map['targetUrl'])) {
            $model->targetUrl = $map['targetUrl'];
        }

        return $model;
    }
}
