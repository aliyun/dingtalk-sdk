<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSchemaAndProcessconfigBatchllyRequest extends Model
{
    /**
     * @var string[]
     */
    public $processCodes;
    protected $_name = [
        'processCodes' => 'processCodes',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->processCodes) {
            $res['processCodes'] = $this->processCodes;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSchemaAndProcessconfigBatchllyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['processCodes'])) {
            if (!empty($map['processCodes'])) {
                $model->processCodes = $map['processCodes'];
            }
        }

        return $model;
    }
}
