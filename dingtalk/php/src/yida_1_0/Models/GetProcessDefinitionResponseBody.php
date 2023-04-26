<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDefinitionResponseBody\originator;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDefinitionResponseBody\owners;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDefinitionResponseBody\tasks;
use AlibabaCloud\Tea\Model;

class GetProcessDefinitionResponseBody extends Model
{
    /**
     * @var string
     */
    public $formUuid;

    /**
     * @var originator
     */
    public $originator;

    /**
     * @var string
     */
    public $outResult;

    /**
     * @var owners[]
     */
    public $owners;

    /**
     * @var string
     */
    public $processId;

    /**
     * @var string
     */
    public $processInstanceId;

    /**
     * @var string
     */
    public $status;

    /**
     * @var tasks[]
     */
    public $tasks;

    /**
     * @var string
     */
    public $title;

    /**
     * @var mixed[]
     */
    public $variables;
    protected $_name = [
        'formUuid'          => 'formUuid',
        'originator'        => 'originator',
        'outResult'         => 'outResult',
        'owners'            => 'owners',
        'processId'         => 'processId',
        'processInstanceId' => 'processInstanceId',
        'status'            => 'status',
        'tasks'             => 'tasks',
        'title'             => 'title',
        'variables'         => 'variables',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->originator) {
            $res['originator'] = null !== $this->originator ? $this->originator->toMap() : null;
        }
        if (null !== $this->outResult) {
            $res['outResult'] = $this->outResult;
        }
        if (null !== $this->owners) {
            $res['owners'] = [];
            if (null !== $this->owners && \is_array($this->owners)) {
                $n = 0;
                foreach ($this->owners as $item) {
                    $res['owners'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->processId) {
            $res['processId'] = $this->processId;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->tasks) {
            $res['tasks'] = [];
            if (null !== $this->tasks && \is_array($this->tasks)) {
                $n = 0;
                foreach ($this->tasks as $item) {
                    $res['tasks'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->variables) {
            $res['variables'] = $this->variables;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetProcessDefinitionResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['originator'])) {
            $model->originator = originator::fromMap($map['originator']);
        }
        if (isset($map['outResult'])) {
            $model->outResult = $map['outResult'];
        }
        if (isset($map['owners'])) {
            if (!empty($map['owners'])) {
                $model->owners = [];
                $n             = 0;
                foreach ($map['owners'] as $item) {
                    $model->owners[$n++] = null !== $item ? owners::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['processId'])) {
            $model->processId = $map['processId'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['tasks'])) {
            if (!empty($map['tasks'])) {
                $model->tasks = [];
                $n            = 0;
                foreach ($map['tasks'] as $item) {
                    $model->tasks[$n++] = null !== $item ? tasks::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['variables'])) {
            $model->variables = $map['variables'];
        }

        return $model;
    }
}
