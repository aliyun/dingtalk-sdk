<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\AssistantResponseResponseBody\output;
use AlibabaCloud\Tea\Model;

class AssistantResponseResponseBody extends Model
{
    /**
     * @var int
     */
    public $createdAt;

    /**
     * @var string
     */
    public $error;

    /**
     * @var string
     */
    public $id;

    /**
     * @var mixed[]
     */
    public $metadata;

    /**
     * @var string
     */
    public $model;

    /**
     * @var string
     */
    public $object;

    /**
     * @var output[]
     */
    public $output;

    /**
     * @var string
     */
    public $status;
    protected $_name = [
        'createdAt' => 'created_at',
        'error' => 'error',
        'id' => 'id',
        'metadata' => 'metadata',
        'model' => 'model',
        'object' => 'object',
        'output' => 'output',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->createdAt) {
            $res['created_at'] = $this->createdAt;
        }
        if (null !== $this->error) {
            $res['error'] = $this->error;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->metadata) {
            $res['metadata'] = $this->metadata;
        }
        if (null !== $this->model) {
            $res['model'] = $this->model;
        }
        if (null !== $this->object) {
            $res['object'] = $this->object;
        }
        if (null !== $this->output) {
            $res['output'] = [];
            if (null !== $this->output && \is_array($this->output)) {
                $n = 0;
                foreach ($this->output as $item) {
                    $res['output'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AssistantResponseResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['created_at'])) {
            $model->createdAt = $map['created_at'];
        }
        if (isset($map['error'])) {
            $model->error = $map['error'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['metadata'])) {
            $model->metadata = $map['metadata'];
        }
        if (isset($map['model'])) {
            $model->model = $map['model'];
        }
        if (isset($map['object'])) {
            $model->object = $map['object'];
        }
        if (isset($map['output'])) {
            if (!empty($map['output'])) {
                $model->output = [];
                $n = 0;
                foreach ($map['output'] as $item) {
                    $model->output[$n++] = null !== $item ? output::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
