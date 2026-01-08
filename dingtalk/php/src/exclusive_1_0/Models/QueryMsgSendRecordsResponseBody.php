<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryMsgSendRecordsResponseBody\result;
use AlibabaCloud\Tea\Model;

class QueryMsgSendRecordsResponseBody extends Model
{
    /**
     * @var string
     */
    public $errmsg;

    /**
     * @var string
     */
    public $errorcode;

    /**
     * @var result
     */
    public $result;
    protected $_name = [
        'errmsg' => 'errmsg',
        'errorcode' => 'errorcode',
        'result' => 'result',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->errmsg) {
            $res['errmsg'] = $this->errmsg;
        }
        if (null !== $this->errorcode) {
            $res['errorcode'] = $this->errorcode;
        }
        if (null !== $this->result) {
            $res['result'] = null !== $this->result ? $this->result->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryMsgSendRecordsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['errmsg'])) {
            $model->errmsg = $map['errmsg'];
        }
        if (isset($map['errorcode'])) {
            $model->errorcode = $map['errorcode'];
        }
        if (isset($map['result'])) {
            $model->result = result::fromMap($map['result']);
        }

        return $model;
    }
}
