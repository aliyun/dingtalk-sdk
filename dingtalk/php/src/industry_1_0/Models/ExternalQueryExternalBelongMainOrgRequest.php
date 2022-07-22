<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class ExternalQueryExternalBelongMainOrgRequest extends Model
{
    /**
     * @description 外部组织类型
     *
     * @var string
     */
    public $externalType;
    protected $_name = [
        'externalType' => 'externalType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->externalType) {
            $res['externalType'] = $this->externalType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExternalQueryExternalBelongMainOrgRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['externalType'])) {
            $model->externalType = $map['externalType'];
        }

        return $model;
    }
}
