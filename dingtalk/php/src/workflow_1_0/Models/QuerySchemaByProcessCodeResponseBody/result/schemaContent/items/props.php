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
     * @description 加班套件4.0新增 加班明细名称。
     *
     * @var string
     */
    public $actionName;

    /**
     * @description textnote的样式，top|middle|bottom。
     *
     * @var string
     */
    public $align;

    /**
     * @description ISV 微应用 appId，用于ISV身份权限识别，ISV可获得相应数据。
     *
     * @var int
     */
    public $appId;

    /**
     * @description 套件是否开启异步获取分条件规则，true：开启；false：不开启。
     *
     * @var bool
     */
    public $asyncCondition;

    /**
     * @description 请假、出差、外出、加班类型标签。
     *
     * @var string
     */
    public $attendTypeLabel;

    /**
     * @description 表单关联控件列表。
     *
     * @var behaviorLinkage[]
     */
    public $behaviorLinkage;

    /**
     * @description 控件业务自定义别名。
     *
     * @var string
     */
    public $bizAlias;

    /**
     * @description 业务套件类型。
     *
     * @var string
     */
    public $bizType;

    /**
     * @description 套件内子组件可见性
     *
     * @var bool[]
     */
    public $childFieldVisible;

    /**
     * @description 内部联系人choice，1表示多选，0表示单选。
     *
     * @var int
     */
    public $choice;

    /**
     * @description common field的commonBizType。
     *
     * @var string
     */
    public $commonBizType;

    /**
     * @description 是否可编辑。
     *
     * @var bool
     */
    public $disabled;

    /**
     * @description 是否自动计算时长。
     *
     * @var bool
     */
    public $duration;

    /**
     * @description 兼容字段。
     *
     * @var string
     */
    public $durationLabel;

    /**
     * @description e签宝专用标识。
     *
     * @var bool
     */
    public $eSign;

    /**
     * @description 套件值是否打平
     *
     * @var bool
     */
    public $extract;

    /**
     * @description 关联表单中的fields存储
     *
     * @var string
     */
    public $fieldsInfo;

    /**
     * @description 时间格式(DDDateField和DDDateRangeField)。
     *
     * @var string
     */
    public $format;

    /**
     * @description 公式。
     *
     * @var string
     */
    public $formula;

    /**
     * @description 加班套件4.0新增 加班明细是否隐藏。
     *
     * @var bool
     */
    public $hidden;

    /**
     * @description textnote在详情页是否隐藏，true隐藏， false不隐藏
     *
     * @var bool
     */
    public $hiddenInApprovalDetail;

    /**
     * @description 加班套件4.0新增 加班明细是否隐藏标签。
     *
     * @var bool
     */
    public $hideLabel;

    /**
     * @description 兼容出勤套件类型。
     *
     * @var string[][]
     */
    public $holidayOptions;

    /**
     * @description 控件 id。
     *
     * @var string
     */
    public $id;

    /**
     * @description 控件名称。
     *
     * @var string
     */
    public $label;

    /**
     * @description label是否可修改 true：不可修改。
     *
     * @var bool
     */
    public $labelEditableFreeze;

    /**
     * @description 说明文案的链接地址。
     *
     * @var string
     */
    public $link;

    /**
     * @description 加班套件4.0新增 加班明细描述。
     *
     * @var string
     */
    public $mainTitle;

    /**
     * @description 是否参与打印(1表示不打印, 0表示打印)。
     *
     * @var string
     */
    public $notPrint;

    /**
     * @description 是否需要大写 默认是需要; 1:不需要大写, 空或者0:需要大写。
     *
     * @var string
     */
    public $notUpper;

    /**
     * @description 选项内容列表，提供给业务方更多的选择器操作。
     *
     * @var objOptions[]
     */
    public $objOptions;

    /**
     * @description 单选框选项列表。
     *
     * @var string[]
     */
    public $options;

    /**
     * @description 是否有支付属性。
     *
     * @var bool
     */
    public $payEnable;

    /**
     * @description 占位符。
     *
     * @var string
     */
    public $placeholder;

    /**
     * @description 同步到考勤, 表示是否设置为员工状态。
     *
     * @var push
     */
    public $push;

    /**
     * @description 推送到考勤, 子类型(DDSelectField)。
     *
     * @var bool
     */
    public $pushToAttendance;

    /**
     * @description 是否推送管理日历(DDDateRangeField, 1表示推送, 0表示不推送, 该属性为兼容保留)。
     *
     * @var int
     */
    public $pushToCalendar;

    /**
     * @description 是否必填。
     *
     * @var bool
     */
    public $required;

    /**
     * @description 必填是否可修改 true：不可修改。
     *
     * @var bool
     */
    public $requiredEditableFreeze;

    /**
     * @description 兼容出勤套件类型。
     *
     * @var bool
     */
    public $showAttendOptions;

    /**
     * @description 是否开启员工状态。
     *
     * @var bool
     */
    public $staffStatusEnabled;

    /**
     * @description 需要计算总和的明细组件
     *
     * @var statField[]
     */
    public $statField;

    /**
     * @description 数字组件/日期区间组件单位属性。
     *
     * @var string
     */
    public $unit;

    /**
     * @description 是否使用考勤日历。
     *
     * @var bool
     */
    public $useCalendar;

    /**
     * @description 明细打印排版方式 false：横向 true：纵向。
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
