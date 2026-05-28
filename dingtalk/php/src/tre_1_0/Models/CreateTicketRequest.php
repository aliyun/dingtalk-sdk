<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtre_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtre_1_0\Models\CreateTicketRequest\reporters;
use AlibabaCloud\Tea\Model;

class CreateTicketRequest extends Model
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
     * @var reporters[]
     */
    public $reporters;
    protected $_name = [
        'description' => 'description',
        'priority' => 'priority',
        'reporters' => 'reporters',
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
        if (null !== $this->reporters) {
            $res['reporters'] = [];
            if (null !== $this->reporters && \is_array($this->reporters)) {
                $n = 0;
                foreach ($this->reporters as $item) {
                    $res['reporters'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTicketRequest
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
            if (!empty($map['reporters'])) {
                $model->reporters = [];
                $n = 0;
                foreach ($map['reporters'] as $item) {
                    $model->reporters[$n++] = null !== $item ? reporters::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
