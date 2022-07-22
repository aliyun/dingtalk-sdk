<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessConfigResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessConfigResponseBody\result\commentConf;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessConfigResponseBody\result\handSignConf;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessConfigResponseBody\result\substituteSubmitConf;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessConfigResponseBody\result\titleGenRule;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessConfigResponseBody\result\visibility;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 自定义摘要信息
     *
     * @var string[]
     */
    public $abstractGenRule;

    /**
     * @description 表单节点权限
     *
     * @var string
     */
    public $activityAuth;

    /**
     * @description 是否允许撤销
     *
     * @var bool
     */
    public $allowRevoke;

    /**
     * @description 是否允许加签
     *
     * @var bool
     */
    public $appendEnable;

    /**
     * @description 如果审批人和发起人是同一个人，则去重
     *
     * @var bool
     */
    public $autoExecuteOriginatorTasks;

    /**
     * @description 流程表单业务标识
     *
     * @var string
     */
    public $bizCategoryId;

    /**
     * @description 纯表单业务标识
     *
     * @var string
     */
    public $bizType;

    /**
     * @description 评论配置
     *
     * @var commentConf
     */
    public $commentConf;

    /**
     * @description 审批人自动去重
     *
     * @var string
     */
    public $duplicateRemoval;

    /**
     * @description 表单配置
     *
     * @var string
     */
    public $formSchema;

    /**
     * @description 手写签名配置
     *
     * @var handSignConf
     */
    public $handSignConf;

    /**
     * @description 表单管理员
     *
     * @var string[]
     */
    public $managers;

    /**
     * @description 表单名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 是否流程表单
     *
     * @var bool
     */
    public $processAppType;

    /**
     * @description 流程配置
     *
     * @var string
     */
    public $processConfig;

    /**
     * @description 是否静态流程
     *
     * @var bool
     */
    public $staticProc;

    /**
     * @description 代提交配置
     *
     * @var substituteSubmitConf
     */
    public $substituteSubmitConf;

    /**
     * @description 自定义标题规则
     *
     * @var titleGenRule
     */
    public $titleGenRule;

    /**
     * @description 模板可见性
     *
     * @var visibility[]
     */
    public $visibility;
    protected $_name = [
        'abstractGenRule'            => 'abstractGenRule',
        'activityAuth'               => 'activityAuth',
        'allowRevoke'                => 'allowRevoke',
        'appendEnable'               => 'appendEnable',
        'autoExecuteOriginatorTasks' => 'autoExecuteOriginatorTasks',
        'bizCategoryId'              => 'bizCategoryId',
        'bizType'                    => 'bizType',
        'commentConf'                => 'commentConf',
        'duplicateRemoval'           => 'duplicateRemoval',
        'formSchema'                 => 'formSchema',
        'handSignConf'               => 'handSignConf',
        'managers'                   => 'managers',
        'name'                       => 'name',
        'processAppType'             => 'processAppType',
        'processConfig'              => 'processConfig',
        'staticProc'                 => 'staticProc',
        'substituteSubmitConf'       => 'substituteSubmitConf',
        'titleGenRule'               => 'titleGenRule',
        'visibility'                 => 'visibility',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->abstractGenRule) {
            $res['abstractGenRule'] = $this->abstractGenRule;
        }
        if (null !== $this->activityAuth) {
            $res['activityAuth'] = $this->activityAuth;
        }
        if (null !== $this->allowRevoke) {
            $res['allowRevoke'] = $this->allowRevoke;
        }
        if (null !== $this->appendEnable) {
            $res['appendEnable'] = $this->appendEnable;
        }
        if (null !== $this->autoExecuteOriginatorTasks) {
            $res['autoExecuteOriginatorTasks'] = $this->autoExecuteOriginatorTasks;
        }
        if (null !== $this->bizCategoryId) {
            $res['bizCategoryId'] = $this->bizCategoryId;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->commentConf) {
            $res['commentConf'] = null !== $this->commentConf ? $this->commentConf->toMap() : null;
        }
        if (null !== $this->duplicateRemoval) {
            $res['duplicateRemoval'] = $this->duplicateRemoval;
        }
        if (null !== $this->formSchema) {
            $res['formSchema'] = $this->formSchema;
        }
        if (null !== $this->handSignConf) {
            $res['handSignConf'] = null !== $this->handSignConf ? $this->handSignConf->toMap() : null;
        }
        if (null !== $this->managers) {
            $res['managers'] = $this->managers;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->processAppType) {
            $res['processAppType'] = $this->processAppType;
        }
        if (null !== $this->processConfig) {
            $res['processConfig'] = $this->processConfig;
        }
        if (null !== $this->staticProc) {
            $res['staticProc'] = $this->staticProc;
        }
        if (null !== $this->substituteSubmitConf) {
            $res['substituteSubmitConf'] = null !== $this->substituteSubmitConf ? $this->substituteSubmitConf->toMap() : null;
        }
        if (null !== $this->titleGenRule) {
            $res['titleGenRule'] = null !== $this->titleGenRule ? $this->titleGenRule->toMap() : null;
        }
        if (null !== $this->visibility) {
            $res['visibility'] = [];
            if (null !== $this->visibility && \is_array($this->visibility)) {
                $n = 0;
                foreach ($this->visibility as $item) {
                    $res['visibility'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['abstractGenRule'])) {
            if (!empty($map['abstractGenRule'])) {
                $model->abstractGenRule = $map['abstractGenRule'];
            }
        }
        if (isset($map['activityAuth'])) {
            $model->activityAuth = $map['activityAuth'];
        }
        if (isset($map['allowRevoke'])) {
            $model->allowRevoke = $map['allowRevoke'];
        }
        if (isset($map['appendEnable'])) {
            $model->appendEnable = $map['appendEnable'];
        }
        if (isset($map['autoExecuteOriginatorTasks'])) {
            $model->autoExecuteOriginatorTasks = $map['autoExecuteOriginatorTasks'];
        }
        if (isset($map['bizCategoryId'])) {
            $model->bizCategoryId = $map['bizCategoryId'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['commentConf'])) {
            $model->commentConf = commentConf::fromMap($map['commentConf']);
        }
        if (isset($map['duplicateRemoval'])) {
            $model->duplicateRemoval = $map['duplicateRemoval'];
        }
        if (isset($map['formSchema'])) {
            $model->formSchema = $map['formSchema'];
        }
        if (isset($map['handSignConf'])) {
            $model->handSignConf = handSignConf::fromMap($map['handSignConf']);
        }
        if (isset($map['managers'])) {
            if (!empty($map['managers'])) {
                $model->managers = $map['managers'];
            }
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['processAppType'])) {
            $model->processAppType = $map['processAppType'];
        }
        if (isset($map['processConfig'])) {
            $model->processConfig = $map['processConfig'];
        }
        if (isset($map['staticProc'])) {
            $model->staticProc = $map['staticProc'];
        }
        if (isset($map['substituteSubmitConf'])) {
            $model->substituteSubmitConf = substituteSubmitConf::fromMap($map['substituteSubmitConf']);
        }
        if (isset($map['titleGenRule'])) {
            $model->titleGenRule = titleGenRule::fromMap($map['titleGenRule']);
        }
        if (isset($map['visibility'])) {
            if (!empty($map['visibility'])) {
                $model->visibility = [];
                $n                 = 0;
                foreach ($map['visibility'] as $item) {
                    $model->visibility[$n++] = null !== $item ? visibility::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
