<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsUpdateRequest;

use AlibabaCloud\Tea\Model;

class relatedLink extends Model
{
    /**
     * @example https://123466.com
     *
     * @var string
     */
    public $link;

    /**
     * @example 相关链接
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'link' => 'link',
        'name' => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->link) {
            $res['link'] = $this->link;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return relatedLink
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['link'])) {
            $model->link = $map['link'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
