<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\GetUserSourceListResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $id;

    /**
     * @var int
     */
    public $status;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $config;

    /**
     * @var string
     */
    public $vendor;

    /**
     * @var string
     */
    public $name;
    protected $_name = [
        'id'          => 'id',
        'status'      => 'status',
        'description' => 'description',
        'config'      => 'config',
        'vendor'      => 'vendor',
        'name'        => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->config) {
            $res['config'] = $this->config;
        }
        if (null !== $this->vendor) {
            $res['vendor'] = $this->vendor;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['config'])) {
            $model->config = $map['config'];
        }
        if (isset($map['vendor'])) {
            $model->vendor = $map['vendor'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
