<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryDeviceListByCorpIdResponseBody\result;
use AlibabaCloud\Tea\Model;

class QueryDeviceListByCorpIdResponseBody extends Model
{
    /**
     * @description Id of the request
     *
     * @var bool
     */
    public $success;

    /**
     * @var result
     */
    public $result;
    protected $_name = [
        'success' => 'success',
        'result'  => 'result',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
     * @return QueryDeviceListByCorpIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['result'])) {
            $model->result = result::fromMap($map['result']);
        }

        return $model;
    }
}
