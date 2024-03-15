<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\QueryReportDetailResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @var string[]
     */
    public $images;

    /**
     * @example 今日工作
     *
     * @var string
     */
    public $key;

    /**
     * @example 0
     *
     * @var string
     */
    public $sort;

    /**
     * @example 1
     *
     * @var string
     */
    public $type;

    /**
     * @example 开发工作
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'images' => 'images',
        'key'    => 'key',
        'sort'   => 'sort',
        'type'   => 'type',
        'value'  => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->images) {
            $res['images'] = $this->images;
        }
        if (null !== $this->key) {
            $res['key'] = $this->key;
        }
        if (null !== $this->sort) {
            $res['sort'] = $this->sort;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['images'])) {
            if (!empty($map['images'])) {
                $model->images = $map['images'];
            }
        }
        if (isset($map['key'])) {
            $model->key = $map['key'];
        }
        if (isset($map['sort'])) {
            $model->sort = $map['sort'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
