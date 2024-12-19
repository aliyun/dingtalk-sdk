<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\SendLivePluginUserActionMsgRequest;

use AlibabaCloud\Tea\Model;

class pluginEffectsMessage extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $count;

    /**
     * @var string
     */
    public $lottieFileUrl;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $msgIconUrl;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $msgText;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $pluginSubId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $senderUnionId;
    protected $_name = [
        'count'         => 'count',
        'lottieFileUrl' => 'lottieFileUrl',
        'msgIconUrl'    => 'msgIconUrl',
        'msgText'       => 'msgText',
        'pluginSubId'   => 'pluginSubId',
        'senderUnionId' => 'senderUnionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->count) {
            $res['count'] = $this->count;
        }
        if (null !== $this->lottieFileUrl) {
            $res['lottieFileUrl'] = $this->lottieFileUrl;
        }
        if (null !== $this->msgIconUrl) {
            $res['msgIconUrl'] = $this->msgIconUrl;
        }
        if (null !== $this->msgText) {
            $res['msgText'] = $this->msgText;
        }
        if (null !== $this->pluginSubId) {
            $res['pluginSubId'] = $this->pluginSubId;
        }
        if (null !== $this->senderUnionId) {
            $res['senderUnionId'] = $this->senderUnionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return pluginEffectsMessage
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['count'])) {
            $model->count = $map['count'];
        }
        if (isset($map['lottieFileUrl'])) {
            $model->lottieFileUrl = $map['lottieFileUrl'];
        }
        if (isset($map['msgIconUrl'])) {
            $model->msgIconUrl = $map['msgIconUrl'];
        }
        if (isset($map['msgText'])) {
            $model->msgText = $map['msgText'];
        }
        if (isset($map['pluginSubId'])) {
            $model->pluginSubId = $map['pluginSubId'];
        }
        if (isset($map['senderUnionId'])) {
            $model->senderUnionId = $map['senderUnionId'];
        }

        return $model;
    }
}
