<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryDeviceResponseBody extends Model
{
    /**
     * @example 1680227019000
     *
     * @var int
     */
    public $gmtExpiry;

    /**
     * @example model1
     *
     * @var string
     */
    public $model;

    /**
     * @example 三年级1班班牌
     *
     * @var string
     */
    public $name;

    /**
     * @example fada-8008
     *
     * @var string
     */
    public $sn;

    /**
     * @example VIDEO_CALL
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'gmtExpiry' => 'gmtExpiry',
        'model'     => 'model',
        'name'      => 'name',
        'sn'        => 'sn',
        'type'      => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->gmtExpiry) {
            $res['gmtExpiry'] = $this->gmtExpiry;
        }
        if (null !== $this->model) {
            $res['model'] = $this->model;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryDeviceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['gmtExpiry'])) {
            $model->gmtExpiry = $map['gmtExpiry'];
        }
        if (isset($map['model'])) {
            $model->model = $map['model'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
