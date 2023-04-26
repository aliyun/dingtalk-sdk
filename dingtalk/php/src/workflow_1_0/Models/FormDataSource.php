<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormDataSource\target;
use AlibabaCloud\Tea\Model;

class FormDataSource extends Model
{
    /**
     * @var target
     */
    public $target;

    /**
     * @example form
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'target' => 'target',
        'type'   => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->target) {
            $res['target'] = null !== $this->target ? $this->target->toMap() : null;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return FormDataSource
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['target'])) {
            $model->target = target::fromMap($map['target']);
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
