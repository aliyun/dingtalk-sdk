<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListOperationLogsResponseBody extends Model
{
    /**
     * @example {"FINST-GW866DA1NHFZIPNE03UTM88NOAGQ27Q9VUP1L0":[{"currentText":null,"componentType":null,"gmtModified":"2022-04-08 11:15:34","preText":null,"operationType":"CREATE","componentName":"","operator":{"userInfo":null,"tbWang":null,"depDesc":null,"displayName":"娄修俊","mastedataDeptments":null,"orderNum":null,"displayEnName":null,"userId":null,"personalPhoto":null,"status":null},"fieldId":null}]}
     *
     * @var mixed[]
     */
    public $operationLogMap;
    protected $_name = [
        'operationLogMap' => 'operationLogMap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operationLogMap) {
            $res['operationLogMap'] = $this->operationLogMap;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListOperationLogsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operationLogMap'])) {
            $model->operationLogMap = $map['operationLogMap'];
        }

        return $model;
    }
}
