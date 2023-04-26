<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListDentriesResponseBody\dentries;

use AlibabaCloud\Tea\Model;

class thumbnail extends Model
{
    /**
     * @example 64
     *
     * @var int
     */
    public $height;

    /**
     * @example url
     *
     * @var string
     */
    public $url;

    /**
     * @example 64
     *
     * @var int
     */
    public $width;
    protected $_name = [
        'height' => 'height',
        'url'    => 'url',
        'width'  => 'width',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->height) {
            $res['height'] = $this->height;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }
        if (null !== $this->width) {
            $res['width'] = $this->width;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return thumbnail
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['height'])) {
            $model->height = $map['height'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }
        if (isset($map['width'])) {
            $model->width = $map['width'];
        }

        return $model;
    }
}
