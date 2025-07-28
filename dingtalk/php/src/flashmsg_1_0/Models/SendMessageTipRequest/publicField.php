<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\SendMessageTipRequest;

use AlibabaCloud\Tea\Model;

class publicField extends Model
{
    /**
     * @example dingtalk://dingtalkclient/page/link33
     *
     * @var string
     */
    public $detailUrl;

    /**
     * @example 限时阅读5分钟
     *
     * @var string
     */
    public $durationDesc;

    /**
     * @var string[]
     */
    public $extension;

    /**
     * @var bool
     */
    public $isExpired;

    /**
     * @example dingtalk://dingtalkclient/page/linkxx
     *
     * @var string
     */
    public $readActionUrl;

    /**
     * @example 已查收 0/1
     *
     * @var string
     */
    public $readProgressDesc;
    protected $_name = [
        'detailUrl' => 'detailUrl',
        'durationDesc' => 'durationDesc',
        'extension' => 'extension',
        'isExpired' => 'isExpired',
        'readActionUrl' => 'readActionUrl',
        'readProgressDesc' => 'readProgressDesc',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->detailUrl) {
            $res['detailUrl'] = $this->detailUrl;
        }
        if (null !== $this->durationDesc) {
            $res['durationDesc'] = $this->durationDesc;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->isExpired) {
            $res['isExpired'] = $this->isExpired;
        }
        if (null !== $this->readActionUrl) {
            $res['readActionUrl'] = $this->readActionUrl;
        }
        if (null !== $this->readProgressDesc) {
            $res['readProgressDesc'] = $this->readProgressDesc;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return publicField
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['detailUrl'])) {
            $model->detailUrl = $map['detailUrl'];
        }
        if (isset($map['durationDesc'])) {
            $model->durationDesc = $map['durationDesc'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['isExpired'])) {
            $model->isExpired = $map['isExpired'];
        }
        if (isset($map['readActionUrl'])) {
            $model->readActionUrl = $map['readActionUrl'];
        }
        if (isset($map['readProgressDesc'])) {
            $model->readProgressDesc = $map['readProgressDesc'];
        }

        return $model;
    }
}
