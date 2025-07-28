<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSchemaAndProcessconfigBatchllyShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $processCodesShrink;
    protected $_name = [
        'processCodesShrink' => 'processCodes',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->processCodesShrink) {
            $res['processCodes'] = $this->processCodesShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSchemaAndProcessconfigBatchllyShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['processCodes'])) {
            $model->processCodesShrink = $map['processCodes'];
        }

        return $model;
    }
}
