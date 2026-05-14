<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateAsrTranscriptionRequest extends Model
{
    /**
     * @var string
     */
    public $bizKey;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'bizKey' => 'bizKey',
        'url' => 'url',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizKey) {
            $res['bizKey'] = $this->bizKey;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateAsrTranscriptionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizKey'])) {
            $model->bizKey = $map['bizKey'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
