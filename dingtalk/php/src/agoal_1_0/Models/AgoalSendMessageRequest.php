<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class AgoalSendMessageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example https://agoal.dingtalk.com
     *
     * @var string
     */
    public $mobileUrl;

    /**
     * @description This parameter is required.
     *
     * @example {"A":"a", "B":"b"}
     *
     * @var string
     */
    public $params;

    /**
     * @description This parameter is required.
     *
     * @example https://agoal.dingtalk.com
     *
     * @var string
     */
    public $pcUrl;

    /**
     * @description This parameter is required.
     *
     * @example 211042291978xxxx
     *
     * @var string
     */
    public $sourceDingUserId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $targetDingUserIds;

    /**
     * @description This parameter is required.
     *
     * @example 1d01a14febc7482ca3b6e1d30cf5xxxx
     *
     * @var string
     */
    public $templateId;
    protected $_name = [
        'mobileUrl'         => 'mobileUrl',
        'params'            => 'params',
        'pcUrl'             => 'pcUrl',
        'sourceDingUserId'  => 'sourceDingUserId',
        'targetDingUserIds' => 'targetDingUserIds',
        'templateId'        => 'templateId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mobileUrl) {
            $res['mobileUrl'] = $this->mobileUrl;
        }
        if (null !== $this->params) {
            $res['params'] = $this->params;
        }
        if (null !== $this->pcUrl) {
            $res['pcUrl'] = $this->pcUrl;
        }
        if (null !== $this->sourceDingUserId) {
            $res['sourceDingUserId'] = $this->sourceDingUserId;
        }
        if (null !== $this->targetDingUserIds) {
            $res['targetDingUserIds'] = $this->targetDingUserIds;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AgoalSendMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mobileUrl'])) {
            $model->mobileUrl = $map['mobileUrl'];
        }
        if (isset($map['params'])) {
            $model->params = $map['params'];
        }
        if (isset($map['pcUrl'])) {
            $model->pcUrl = $map['pcUrl'];
        }
        if (isset($map['sourceDingUserId'])) {
            $model->sourceDingUserId = $map['sourceDingUserId'];
        }
        if (isset($map['targetDingUserIds'])) {
            if (!empty($map['targetDingUserIds'])) {
                $model->targetDingUserIds = $map['targetDingUserIds'];
            }
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }

        return $model;
    }
}
