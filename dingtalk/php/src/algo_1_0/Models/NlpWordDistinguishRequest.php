<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\NlpWordDistinguishRequest\attachExtractDecisionInfo;
use AlibabaCloud\Tea\Model;

class NlpWordDistinguishRequest extends Model
{
    /**
     * @var attachExtractDecisionInfo
     */
    public $attachExtractDecisionInfo;

    /**
     * @var string
     */
    public $isvAppId;

    /**
     * @var string
     */
    public $text;
    protected $_name = [
        'attachExtractDecisionInfo' => 'attachExtractDecisionInfo',
        'isvAppId'                  => 'isvAppId',
        'text'                      => 'text',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attachExtractDecisionInfo) {
            $res['attachExtractDecisionInfo'] = null !== $this->attachExtractDecisionInfo ? $this->attachExtractDecisionInfo->toMap() : null;
        }
        if (null !== $this->isvAppId) {
            $res['isvAppId'] = $this->isvAppId;
        }
        if (null !== $this->text) {
            $res['text'] = $this->text;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return NlpWordDistinguishRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attachExtractDecisionInfo'])) {
            $model->attachExtractDecisionInfo = attachExtractDecisionInfo::fromMap($map['attachExtractDecisionInfo']);
        }
        if (isset($map['isvAppId'])) {
            $model->isvAppId = $map['isvAppId'];
        }
        if (isset($map['text'])) {
            $model->text = $map['text'];
        }

        return $model;
    }
}
