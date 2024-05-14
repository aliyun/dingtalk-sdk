<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmanufacturing_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vmanufacturing_1_0\Models\IndustrializeManufactureJobBookResponseBody\content;
use AlibabaCloud\Tea\Model;

class IndustrializeManufactureJobBookResponseBody extends Model
{
    /**
     * @var content
     */
    public $content;

    /**
     * @var string
     */
    public $errorCode;

    /**
     * @var int
     */
    public $errorLevel;

    /**
     * @var string
     */
    public $errorMsg;

    /**
     * @var string
     */
    public $httpCode;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $success;

    /**
     * @var string
     */
    public $uuid;
    protected $_name = [
        'content'    => 'content',
        'errorCode'  => 'errorCode',
        'errorLevel' => 'errorLevel',
        'errorMsg'   => 'errorMsg',
        'httpCode'   => 'httpCode',
        'success'    => 'success',
        'uuid'       => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = null !== $this->content ? $this->content->toMap() : null;
        }
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->errorLevel) {
            $res['errorLevel'] = $this->errorLevel;
        }
        if (null !== $this->errorMsg) {
            $res['errorMsg'] = $this->errorMsg;
        }
        if (null !== $this->httpCode) {
            $res['httpCode'] = $this->httpCode;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IndustrializeManufactureJobBookResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = content::fromMap($map['content']);
        }
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['errorLevel'])) {
            $model->errorLevel = $map['errorLevel'];
        }
        if (isset($map['errorMsg'])) {
            $model->errorMsg = $map['errorMsg'];
        }
        if (isset($map['httpCode'])) {
            $model->httpCode = $map['httpCode'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
