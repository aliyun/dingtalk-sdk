<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListEmpLeaveRecordsResponseBody\result;
use AlibabaCloud\Tea\Model;

class ListEmpLeaveRecordsResponseBody extends Model
{
    /**
     * @description errorMsg
     *
     * @var string
     */
    public $errorMsg;

    /**
     * @description dingOpenErrcode
     *
     * @var int
     */
    public $dingOpenErrcode;

    /**
     * @description success
     *
     * @var bool
     */
    public $success;

    /**
     * @description result
     *
     * @var result
     */
    public $result;
    protected $_name = [
        'errorMsg'        => 'errorMsg',
        'dingOpenErrcode' => 'dingOpenErrcode',
        'success'         => 'success',
        'result'          => 'result',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->errorMsg) {
            $res['errorMsg'] = $this->errorMsg;
        }
        if (null !== $this->dingOpenErrcode) {
            $res['dingOpenErrcode'] = $this->dingOpenErrcode;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->result) {
            $res['result'] = null !== $this->result ? $this->result->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListEmpLeaveRecordsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['errorMsg'])) {
            $model->errorMsg = $map['errorMsg'];
        }
        if (isset($map['dingOpenErrcode'])) {
            $model->dingOpenErrcode = $map['dingOpenErrcode'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['result'])) {
            $model->result = result::fromMap($map['result']);
        }

        return $model;
    }
}
