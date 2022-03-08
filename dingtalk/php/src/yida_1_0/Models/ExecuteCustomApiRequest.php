<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class ExecuteCustomApiRequest extends Model
{
    /**
     * @var string
     */
    public $appType;

    /**
     * @var string
     */
    public $data;

    /**
     * @var string
     */
    public $language;

    /**
     * @var string
     */
    public $serviceId;

    /**
     * @var string
     */
    public $systemToken;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'     => 'appType',
        'data'        => 'data',
        'language'    => 'language',
        'serviceId'   => 'serviceId',
        'systemToken' => 'systemToken',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->serviceId) {
            $res['serviceId'] = $this->serviceId;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExecuteCustomApiRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['serviceId'])) {
            $model->serviceId = $map['serviceId'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
