<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryDigitalDistrictOrgInfoResponseBody extends Model
{
    /**
     * @description arguments
     *
     * @var string[]
     */
    public $arguments;

    /**
     * @description result
     *
     * @var string
     */
    public $result;
    protected $_name = [
        'arguments' => 'arguments',
        'result'    => 'result',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->arguments) {
            $res['arguments'] = $this->arguments;
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryDigitalDistrictOrgInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['arguments'])) {
            if (!empty($map['arguments'])) {
                $model->arguments = $map['arguments'];
            }
        }
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }

        return $model;
    }
}
