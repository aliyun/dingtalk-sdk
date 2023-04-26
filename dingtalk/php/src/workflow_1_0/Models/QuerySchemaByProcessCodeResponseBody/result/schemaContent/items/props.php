<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody\result\schemaContent\items;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody\result\schemaContent\items\props\behaviorLinkage;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody\result\schemaContent\items\props\objOptions;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody\result\schemaContent\items\props\push;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody\result\schemaContent\items\props\statField;
use AlibabaCloud\Tea\Model;

class props extends Model
{
    /**
     * @example 添加
     *
     * @var string
     */
    public $actionName;

    /**
     * @example top
     *
     * @var string
     */
    public $align;

    /**
     * @example 1234567
     *
     * @var int
     */
    public $appId;

    /**
     * @example true
     *
     * @var bool
     */
    public $asyncCondition;

    /**
     * @example 请假
     *
     * @var string
     */
    public $attendTypeLabel;

    /**
     * @var behaviorLinkage[]
     */
    public $behaviorLinkage;

    /**
     * @example 我的单行输入框
     *
     * @var string
     */
    public $bizAlias;

    /**
     * @example hrm.xxxx
     *
     * @var string
     */
    public $bizType;

    /**
     * @var bool[]
     */
    public $childFieldVisible;

    /**
     * @example 1
     *
     * @var int
     */
    public $choice;

    /**
     * @example xxxx
     *
     * @var string
     */
    public $commonBizType;

    /**
     * @example true
     *
     * @var bool
     */
    public $disabled;

    /**
     * @example true
     *
     * @var bool
     */
    public $duration;

    /**
     * @example xxxx
     *
     * @var string
     */
    public $durationLabel;

    /**
     * @example true
     *
     * @var bool
     */
    public $eSign;

    /**
     * @example true
     *
     * @var bool
     */
    public $extract;

    /**
     * @example xxxx
     *
     * @var string
     */
    public $fieldsInfo;

    /**
     * @example yyyy-MM-dd
     *
     * @var string
     */
    public $format;

    /**
     * @example xxxx
     *
     * @var string
     */
    public $formula;

    /**
     * @example true
     *
     * @var bool
     */
    public $hidden;

    /**
     * @example true
     *
     * @var bool
     */
    public $hiddenInApprovalDetail;

    /**
     * @example true
     *
     * @var bool
     */
    public $hideLabel;

    /**
     * @example "[{\"name\":\"\open"}]"
     *
     * @var string[][]
     */
    public $holidayOptions;

    /**
     * @example TextField-K2AD4O5B
     *
     * @var string
     */
    public $id;

    /**
     * @example 单行输入框
     *
     * @var string
     */
    public $label;

    /**
     * @example true
     *
     * @var bool
     */
    public $labelEditableFreeze;

    /**
     * @example xxxx
     *
     * @var string
     */
    public $link;

    /**
     * @example xxxx
     *
     * @var string
     */
    public $mainTitle;

    /**
     * @example 1
     *
     * @var string
     */
    public $notPrint;

    /**
     * @example 1
     *
     * @var string
     */
    public $notUpper;

    /**
     * @var objOptions[]
     */
    public $objOptions;

    /**
     * @var string[]
     */
    public $options;

    /**
     * @example true
     *
     * @var bool
     */
    public $payEnable;

    /**
     * @example 请输入文字
     *
     * @var string
     */
    public $placeholder;

    /**
     * @var push
     */
    public $push;

    /**
     * @example true
     *
     * @var bool
     */
    public $pushToAttendance;

    /**
     * @example 1
     *
     * @var int
     */
    public $pushToCalendar;

    /**
     * @example true
     *
     * @var bool
     */
    public $required;

    /**
     * @example true
     *
     * @var bool
     */
    public $requiredEditableFreeze;

    /**
     * @example true
     *
     * @var bool
     */
    public $showAttendOptions;

    /**
     * @example true
     *
     * @var bool
     */
    public $staffStatusEnabled;

    /**
     * @var statField[]
     */
    public $statField;

    /**
     * @example 天
     *
     * @var string
     */
    public $unit;

    /**
     * @example true
     *
     * @var bool
     */
    public $useCalendar;

    /**
     * @example true
     *
     * @var bool
     */
    public $verticalPrint;
    protected $_name = [
        'actionName'             => 'actionName',
        'align'                  => 'align',
        'appId'                  => 'appId',
        'asyncCondition'         => 'asyncCondition',
        'attendTypeLabel'        => 'attendTypeLabel',
        'behaviorLinkage'        => 'behaviorLinkage',
        'bizAlias'               => 'bizAlias',
        'bizType'                => 'bizType',
        'childFieldVisible'      => 'childFieldVisible',
        'choice'                 => 'choice',
        'commonBizType'          => 'commonBizType',
        'disabled'               => 'disabled',
        'duration'               => 'duration',
        'durationLabel'          => 'durationLabel',
        'eSign'                  => 'eSign',
        'extract'                => 'extract',
        'fieldsInfo'             => 'fieldsInfo',
        'format'                 => 'format',
        'formula'                => 'formula',
        'hidden'                 => 'hidden',
        'hiddenInApprovalDetail' => 'hiddenInApprovalDetail',
        'hideLabel'              => 'hideLabel',
        'holidayOptions'         => 'holidayOptions',
        'id'                     => 'id',
        'label'                  => 'label',
        'labelEditableFreeze'    => 'labelEditableFreeze',
        'link'                   => 'link',
        'mainTitle'              => 'mainTitle',
        'notPrint'               => 'notPrint',
        'notUpper'               => 'notUpper',
        'objOptions'             => 'objOptions',
        'options'                => 'options',
        'payEnable'              => 'payEnable',
        'placeholder'            => 'placeholder',
        'push'                   => 'push',
        'pushToAttendance'       => 'pushToAttendance',
        'pushToCalendar'         => 'pushToCalendar',
        'required'               => 'required',
        'requiredEditableFreeze' => 'requiredEditableFreeze',
        'showAttendOptions'      => 'showAttendOptions',
        'staffStatusEnabled'     => 'staffStatusEnabled',
        'statField'              => 'statField',
        'unit'                   => 'unit',
        'useCalendar'            => 'useCalendar',
        'verticalPrint'          => 'verticalPrint',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionName) {
            $res['actionName'] = $this->actionName;
        }
        if (null !== $this->align) {
            $res['align'] = $this->align;
        }
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->asyncCondition) {
            $res['asyncCondition'] = $this->asyncCondition;
        }
        if (null !== $this->attendTypeLabel) {
            $res['attendTypeLabel'] = $this->attendTypeLabel;
        }
        if (null !== $this->behaviorLinkage) {
            $res['behaviorLinkage'] = [];
            if (null !== $this->behaviorLinkage && \is_array($this->behaviorLinkage)) {
                $n = 0;
                foreach ($this->behaviorLinkage as $item) {
                    $res['behaviorLinkage'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->bizAlias) {
            $res['bizAlias'] = $this->bizAlias;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->childFieldVisible) {
            $res['childFieldVisible'] = $this->childFieldVisible;
        }
        if (null !== $this->choice) {
            $res['choice'] = $this->choice;
        }
        if (null !== $this->commonBizType) {
            $res['commonBizType'] = $this->commonBizType;
        }
        if (null !== $this->disabled) {
            $res['disabled'] = $this->disabled;
        }
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->durationLabel) {
            $res['durationLabel'] = $this->durationLabel;
        }
        if (null !== $this->eSign) {
            $res['eSign'] = $this->eSign;
        }
        if (null !== $this->extract) {
            $res['extract'] = $this->extract;
        }
        if (null !== $this->fieldsInfo) {
            $res['fieldsInfo'] = $this->fieldsInfo;
        }
        if (null !== $this->format) {
            $res['format'] = $this->format;
        }
        if (null !== $this->formula) {
            $res['formula'] = $this->formula;
        }
        if (null !== $this->hidden) {
            $res['hidden'] = $this->hidden;
        }
        if (null !== $this->hiddenInApprovalDetail) {
            $res['hiddenInApprovalDetail'] = $this->hiddenInApprovalDetail;
        }
        if (null !== $this->hideLabel) {
            $res['hideLabel'] = $this->hideLabel;
        }
        if (null !== $this->holidayOptions) {
            $res['holidayOptions'] = $this->holidayOptions;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->label) {
            $res['label'] = $this->label;
        }
        if (null !== $this->labelEditableFreeze) {
            $res['labelEditableFreeze'] = $this->labelEditableFreeze;
        }
        if (null !== $this->link) {
            $res['link'] = $this->link;
        }
        if (null !== $this->mainTitle) {
            $res['mainTitle'] = $this->mainTitle;
        }
        if (null !== $this->notPrint) {
            $res['notPrint'] = $this->notPrint;
        }
        if (null !== $this->notUpper) {
            $res['notUpper'] = $this->notUpper;
        }
        if (null !== $this->objOptions) {
            $res['objOptions'] = [];
            if (null !== $this->objOptions && \is_array($this->objOptions)) {
                $n = 0;
                foreach ($this->objOptions as $item) {
                    $res['objOptions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->options) {
            $res['options'] = $this->options;
        }
        if (null !== $this->payEnable) {
            $res['payEnable'] = $this->payEnable;
        }
        if (null !== $this->placeholder) {
            $res['placeholder'] = $this->placeholder;
        }
        if (null !== $this->push) {
            $res['push'] = null !== $this->push ? $this->push->toMap() : null;
        }
        if (null !== $this->pushToAttendance) {
            $res['pushToAttendance'] = $this->pushToAttendance;
        }
        if (null !== $this->pushToCalendar) {
            $res['pushToCalendar'] = $this->pushToCalendar;
        }
        if (null !== $this->required) {
            $res['required'] = $this->required;
        }
        if (null !== $this->requiredEditableFreeze) {
            $res['requiredEditableFreeze'] = $this->requiredEditableFreeze;
        }
        if (null !== $this->showAttendOptions) {
            $res['showAttendOptions'] = $this->showAttendOptions;
        }
        if (null !== $this->staffStatusEnabled) {
            $res['staffStatusEnabled'] = $this->staffStatusEnabled;
        }
        if (null !== $this->statField) {
            $res['statField'] = [];
            if (null !== $this->statField && \is_array($this->statField)) {
                $n = 0;
                foreach ($this->statField as $item) {
                    $res['statField'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }
        if (null !== $this->useCalendar) {
            $res['useCalendar'] = $this->useCalendar;
        }
        if (null !== $this->verticalPrint) {
            $res['verticalPrint'] = $this->verticalPrint;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return props
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionName'])) {
            $model->actionName = $map['actionName'];
        }
        if (isset($map['align'])) {
            $model->align = $map['align'];
        }
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['asyncCondition'])) {
            $model->asyncCondition = $map['asyncCondition'];
        }
        if (isset($map['attendTypeLabel'])) {
            $model->attendTypeLabel = $map['attendTypeLabel'];
        }
        if (isset($map['behaviorLinkage'])) {
            if (!empty($map['behaviorLinkage'])) {
                $model->behaviorLinkage = [];
                $n                      = 0;
                foreach ($map['behaviorLinkage'] as $item) {
                    $model->behaviorLinkage[$n++] = null !== $item ? behaviorLinkage::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['bizAlias'])) {
            $model->bizAlias = $map['bizAlias'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['childFieldVisible'])) {
            $model->childFieldVisible = $map['childFieldVisible'];
        }
        if (isset($map['choice'])) {
            $model->choice = $map['choice'];
        }
        if (isset($map['commonBizType'])) {
            $model->commonBizType = $map['commonBizType'];
        }
        if (isset($map['disabled'])) {
            $model->disabled = $map['disabled'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['durationLabel'])) {
            $model->durationLabel = $map['durationLabel'];
        }
        if (isset($map['eSign'])) {
            $model->eSign = $map['eSign'];
        }
        if (isset($map['extract'])) {
            $model->extract = $map['extract'];
        }
        if (isset($map['fieldsInfo'])) {
            $model->fieldsInfo = $map['fieldsInfo'];
        }
        if (isset($map['format'])) {
            $model->format = $map['format'];
        }
        if (isset($map['formula'])) {
            $model->formula = $map['formula'];
        }
        if (isset($map['hidden'])) {
            $model->hidden = $map['hidden'];
        }
        if (isset($map['hiddenInApprovalDetail'])) {
            $model->hiddenInApprovalDetail = $map['hiddenInApprovalDetail'];
        }
        if (isset($map['hideLabel'])) {
            $model->hideLabel = $map['hideLabel'];
        }
        if (isset($map['holidayOptions'])) {
            if (!empty($map['holidayOptions'])) {
                $model->holidayOptions = $map['holidayOptions'];
            }
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['labelEditableFreeze'])) {
            $model->labelEditableFreeze = $map['labelEditableFreeze'];
        }
        if (isset($map['link'])) {
            $model->link = $map['link'];
        }
        if (isset($map['mainTitle'])) {
            $model->mainTitle = $map['mainTitle'];
        }
        if (isset($map['notPrint'])) {
            $model->notPrint = $map['notPrint'];
        }
        if (isset($map['notUpper'])) {
            $model->notUpper = $map['notUpper'];
        }
        if (isset($map['objOptions'])) {
            if (!empty($map['objOptions'])) {
                $model->objOptions = [];
                $n                 = 0;
                foreach ($map['objOptions'] as $item) {
                    $model->objOptions[$n++] = null !== $item ? objOptions::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['options'])) {
            if (!empty($map['options'])) {
                $model->options = $map['options'];
            }
        }
        if (isset($map['payEnable'])) {
            $model->payEnable = $map['payEnable'];
        }
        if (isset($map['placeholder'])) {
            $model->placeholder = $map['placeholder'];
        }
        if (isset($map['push'])) {
            $model->push = push::fromMap($map['push']);
        }
        if (isset($map['pushToAttendance'])) {
            $model->pushToAttendance = $map['pushToAttendance'];
        }
        if (isset($map['pushToCalendar'])) {
            $model->pushToCalendar = $map['pushToCalendar'];
        }
        if (isset($map['required'])) {
            $model->required = $map['required'];
        }
        if (isset($map['requiredEditableFreeze'])) {
            $model->requiredEditableFreeze = $map['requiredEditableFreeze'];
        }
        if (isset($map['showAttendOptions'])) {
            $model->showAttendOptions = $map['showAttendOptions'];
        }
        if (isset($map['staffStatusEnabled'])) {
            $model->staffStatusEnabled = $map['staffStatusEnabled'];
        }
        if (isset($map['statField'])) {
            if (!empty($map['statField'])) {
                $model->statField = [];
                $n                = 0;
                foreach ($map['statField'] as $item) {
                    $model->statField[$n++] = null !== $item ? statField::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['useCalendar'])) {
            $model->useCalendar = $map['useCalendar'];
        }
        if (isset($map['verticalPrint'])) {
            $model->verticalPrint = $map['verticalPrint'];
        }

        return $model;
    }
}
