<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models\QueryRedeemVipMemberResponseBody\queryResults;
use AlibabaCloud\Tea\Model;

class QueryRedeemVipMemberResponseBody extends Model
{
    /**
     * @var string
     */
    public $errorCode;

    /**
     * @var string
     */
    public $errorMsg;

    /**
     * @var queryResults[]
     */
    public $queryResults;

    /**
     * @var bool
     */
    public $result;
    protected $_name = [
        'errorCode' => 'errorCode',
        'errorMsg' => 'errorMsg',
        'queryResults' => 'queryResults',
        'result' => 'result',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->errorMsg) {
            $res['errorMsg'] = $this->errorMsg;
        }
        if (null !== $this->queryResults) {
            $res['queryResults'] = [];
            if (null !== $this->queryResults && \is_array($this->queryResults)) {
                $n = 0;
                foreach ($this->queryResults as $item) {
                    $res['queryResults'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryRedeemVipMemberResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['errorMsg'])) {
            $model->errorMsg = $map['errorMsg'];
        }
        if (isset($map['queryResults'])) {
            if (!empty($map['queryResults'])) {
                $model->queryResults = [];
                $n = 0;
                foreach ($map['queryResults'] as $item) {
                    $model->queryResults[$n++] = null !== $item ? queryResults::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }

        return $model;
    }
}
