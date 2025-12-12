<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\UpdateFeedContentRequest\content;

use AlibabaCloud\Tea\Model;

class dslTemplateContent extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example https://xxxxx.xxx.com/v1.0/test.html
     *
     * @var string
     */
    public $applyUrl;

    /**
     * @description This parameter is required.
     *
     * @example {"date":"2025-11-06"}
     *
     * @var string
     */
    public $body;
    protected $_name = [
        'applyUrl' => 'applyUrl',
        'body' => 'body',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->applyUrl) {
            $res['applyUrl'] = $this->applyUrl;
        }
        if (null !== $this->body) {
            $res['body'] = $this->body;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dslTemplateContent
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['applyUrl'])) {
            $model->applyUrl = $map['applyUrl'];
        }
        if (isset($map['body'])) {
            $model->body = $map['body'];
        }

        return $model;
    }
}
