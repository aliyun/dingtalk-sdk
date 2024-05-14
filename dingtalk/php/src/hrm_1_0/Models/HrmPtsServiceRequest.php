<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrmPtsServiceRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example dev  or online
     *
     * @var string
     */
    public $env;

    /**
     * @example GET/POST
     *
     * @var string
     */
    public $method;

    /**
     * @description This parameter is required.
     *
     * @example abd123213
     *
     * @var string
     */
    public $outerId;

    /**
     * @var mixed
     */
    public $params;

    /**
     * @description This parameter is required.
     *
     * @example /user/role/get
     *
     * @var string
     */
    public $path;
    protected $_name = [
        'env'     => 'env',
        'method'  => 'method',
        'outerId' => 'outerId',
        'params'  => 'params',
        'path'    => 'path',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->env) {
            $res['env'] = $this->env;
        }
        if (null !== $this->method) {
            $res['method'] = $this->method;
        }
        if (null !== $this->outerId) {
            $res['outerId'] = $this->outerId;
        }
        if (null !== $this->params) {
            $res['params'] = $this->params;
        }
        if (null !== $this->path) {
            $res['path'] = $this->path;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrmPtsServiceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['env'])) {
            $model->env = $map['env'];
        }
        if (isset($map['method'])) {
            $model->method = $map['method'];
        }
        if (isset($map['outerId'])) {
            $model->outerId = $map['outerId'];
        }
        if (isset($map['params'])) {
            $model->params = $map['params'];
        }
        if (isset($map['path'])) {
            $model->path = $map['path'];
        }

        return $model;
    }
}
