<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCustomerCardResponseBody extends Model
{
    /**
     * @var int
     */
    public $dingOpenErrcode;

    /**
     * @var string
     */
    public $errorMsg;

    /**
     * @var bool
     */
    public $result;

    /**
     * @var bool
     */
    public $success;
    protected $_name = [
        'dingOpenErrcode' => 'dingOpenErrcode',
        'errorMsg'        => 'errorMsg',
        'result'          => 'result',
        'success'         => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingOpenErrcode) {
            $res['dingOpenErrcode'] = $this->dingOpenErrcode;
        }
        if (null !== $this->errorMsg) {
            $res['errorMsg'] = $this->errorMsg;
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCustomerCardResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingOpenErrcode'])) {
            $model->dingOpenErrcode = $map['dingOpenErrcode'];
        }
        if (isset($map['errorMsg'])) {
            $model->errorMsg = $map['errorMsg'];
        }
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
