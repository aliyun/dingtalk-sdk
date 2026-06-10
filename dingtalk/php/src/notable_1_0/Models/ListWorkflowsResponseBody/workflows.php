<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ListWorkflowsResponseBody;

use AlibabaCloud\Tea\Model;

class workflows extends Model
{
    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $flowId;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $versionId;
    protected $_name = [
        'description' => 'description',
        'flowId' => 'flowId',
        'name' => 'name',
        'status' => 'status',
        'versionId' => 'versionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->flowId) {
            $res['flowId'] = $this->flowId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->versionId) {
            $res['versionId'] = $this->versionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return workflows
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['flowId'])) {
            $model->flowId = $map['flowId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['versionId'])) {
            $model->versionId = $map['versionId'];
        }

        return $model;
    }
}
