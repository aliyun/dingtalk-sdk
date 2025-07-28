<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\SendDingTipRequest;

use AlibabaCloud\Tea\Model;

class link extends Model
{
    /**
     * @var string[]
     */
    public $extension;

    /**
     * @description This parameter is required.
     *
     * @example dingtalk://dingtalkclient/page/link?pc_slide=true
     *
     * @var string
     */
    public $linkUrl;

    /**
     * @example @lQLPDhrngMo4hi3NAZDNAZCwqp0RL2MfbesBqImWncBnAA2BCD
     *
     * @var string
     */
    public $picMediaId;

    /**
     * @description This parameter is required.
     *
     * @example 今天 10:00后超期
     *
     * @var string
     */
    public $text;
    protected $_name = [
        'extension' => 'extension',
        'linkUrl' => 'linkUrl',
        'picMediaId' => 'picMediaId',
        'text' => 'text',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->linkUrl) {
            $res['linkUrl'] = $this->linkUrl;
        }
        if (null !== $this->picMediaId) {
            $res['picMediaId'] = $this->picMediaId;
        }
        if (null !== $this->text) {
            $res['text'] = $this->text;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return link
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['linkUrl'])) {
            $model->linkUrl = $map['linkUrl'];
        }
        if (isset($map['picMediaId'])) {
            $model->picMediaId = $map['picMediaId'];
        }
        if (isset($map['text'])) {
            $model->text = $map['text'];
        }

        return $model;
    }
}
