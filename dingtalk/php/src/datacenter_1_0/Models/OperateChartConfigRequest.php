<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class OperateChartConfigRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 123
     *
     * @var string
     */
    public $apiKey;

    /**
     * @description This parameter is required.
     *
     * @example 123
     *
     * @var string
     */
    public $corpId;

    /**
     * @var mixed[]
     */
    public $param;

    /**
     * @description This parameter is required.
     *
     * @example 8ABvoWxoelSxcxZBsF3MeWBDe5oi8jmFtU790jhpRoLrfJDWO8UDHbUqvTb3pQA5
     *
     * @var string
     */
    public $ticket;

    /**
     * @description This parameter is required.
     *
     * @example 123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'apiKey' => 'apiKey',
        'corpId' => 'corpId',
        'param' => 'param',
        'ticket' => 'ticket',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->apiKey) {
            $res['apiKey'] = $this->apiKey;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->param) {
            $res['param'] = $this->param;
        }
        if (null !== $this->ticket) {
            $res['ticket'] = $this->ticket;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OperateChartConfigRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['apiKey'])) {
            $model->apiKey = $map['apiKey'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['param'])) {
            $model->param = $map['param'];
        }
        if (isset($map['ticket'])) {
            $model->ticket = $map['ticket'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
