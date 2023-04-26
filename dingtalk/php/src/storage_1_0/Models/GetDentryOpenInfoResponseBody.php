<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDentryOpenInfoResponseBody extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $hasWaterMark;

    /**
     * @example url
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'hasWaterMark' => 'hasWaterMark',
        'url'          => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasWaterMark) {
            $res['hasWaterMark'] = $this->hasWaterMark;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDentryOpenInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasWaterMark'])) {
            $model->hasWaterMark = $map['hasWaterMark'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
