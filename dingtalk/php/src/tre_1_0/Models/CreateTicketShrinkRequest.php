<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtre_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateTicketShrinkRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $priority;

    /**
     * @var string
     */
    public $reportersShrink;
    protected $_name = [
        'description' => 'description',
        'priority' => 'priority',
        'reportersShrink' => 'reporters',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->reportersShrink) {
            $res['reporters'] = $this->reportersShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTicketShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['reporters'])) {
            $model->reportersShrink = $map['reporters'];
        }

        return $model;
    }
}
