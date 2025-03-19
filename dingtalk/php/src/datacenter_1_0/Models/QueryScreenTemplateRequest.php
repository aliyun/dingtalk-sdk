<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryScreenTemplateRequest extends Model
{
    /**
     * @var string
     */
    public $operatorId;

    /**
     * @var bool
     */
    public $sample;
    protected $_name = [
        'operatorId' => 'operatorId',
        'sample' => 'sample',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->sample) {
            $res['sample'] = $this->sample;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryScreenTemplateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['sample'])) {
            $model->sample = $map['sample'];
        }

        return $model;
    }
}
