<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormComponentProps\statField;
use AlibabaCloud\Tea\Model;

class FormComponentProps extends Model
{
    /**
     * @description 明细控件按钮显示文案
     *
     * @var string
     */
    public $actionName;

    /**
     * @description 地址控件模式city省市,district省市区,street省市区街道
     *
     * @var string
     */
    public $addressModel;

    /**
     * @description 文字提示控件显示方式:top|middle|bottom
     *
     * @var string
     */
    public $align;

    /**
     * @description 套件中控件是否可设置为分条件字段
     *
     * @var bool
     */
    public $asyncCondition;

    /**
     * @description 关联审批单控件限定模板列表
     *
     * @var AvaliableTemplate[]
     */
    public $availableTemplates;

    /**
     * @description 业务别名
     *
     * @var string
     */
    public $bizAlias;

    /**
     * @description 套件的业务标识
     *
     * @var string
     */
    public $bizType;

    /**
     * @description 联系人控件是否支持多选，1多选，0单选
     *
     * @var string
     */
    public $choice;

    /**
     * @description 自定义控件渲染标识
     *
     * @var string
     */
    public $commonBizType;

    /**
     * @description 控件表单内唯一id
     *
     * @var string
     */
    public $componentId;

    /**
     * @description 说明文字控件内容
     *
     * @var string
     */
    public $content;

    /**
     * @description 关联数据源配置
     *
     * @var FormDataSource
     */
    public $dataSource;

    /**
     * @description 是否不可编辑
     *
     * @var bool
     */
    public $disabled;

    /**
     * @description 是否自动计算时长
     *
     * @var bool
     */
    public $duration;

    /**
     * @description 时间格式
     *
     * @var string
     */
    public $format;

    /**
     * @description 公式
     *
     * @var string
     */
    public $formula;

    /**
     * @description 是否隐藏字段
     *
     * @var bool
     */
    public $invisible;

    /**
     * @description 控件标题
     *
     * @var string
     */
    public $label;

    /**
     * @description 评分控件上限
     *
     * @var int
     */
    public $limit;

    /**
     * @description 说明文字控件链接地址
     *
     * @var string
     */
    public $link;

    /**
     * @description 文本控件支持的最大长度
     *
     * @var int
     */
    public $maxLength;

    /**
     * @description 电话控件支持的类型
     *
     * @var string
     */
    public $mode;

    /**
     * @description 部门控件是否可多选
     *
     * @var bool
     */
    public $multiple;

    /**
     * @description 单选多选控件选项列表
     *
     * @var SelectOption[]
     */
    public $options;

    /**
     * @description 输入提示
     *
     * @var string
     */
    public $placeholder;

    /**
     * @description 字段是否可打印，1打印，0不打印，默认打印
     *
     * @var string
     */
    public $print;

    /**
     * @description 是否必填
     *
     * @var bool
     */
    public $required;

    /**
     * @description 明细控件数据汇总统计
     *
     * @var statField[]
     */
    public $statField;

    /**
     * @description 明细填写方式，table（表格）、list（列表）
     *
     * @var string
     */
    public $tableViewMode;

    /**
     * @description 时间单位（天、小时）
     *
     * @var string
     */
    public $unit;

    /**
     * @description 金额控件是否需要大写，1不需要大写，其他需要大写
     *
     * @var string
     */
    public $upper;

    /**
     * @description 明细打印方式false横向，true纵向
     *
     * @var bool
     */
    public $verticalPrint;
    protected $_name = [
        'actionName'         => 'actionName',
        'addressModel'       => 'addressModel',
        'align'              => 'align',
        'asyncCondition'     => 'asyncCondition',
        'availableTemplates' => 'availableTemplates',
        'bizAlias'           => 'bizAlias',
        'bizType'            => 'bizType',
        'choice'             => 'choice',
        'commonBizType'      => 'commonBizType',
        'componentId'        => 'componentId',
        'content'            => 'content',
        'dataSource'         => 'dataSource',
        'disabled'           => 'disabled',
        'duration'           => 'duration',
        'format'             => 'format',
        'formula'            => 'formula',
        'invisible'          => 'invisible',
        'label'              => 'label',
        'limit'              => 'limit',
        'link'               => 'link',
        'maxLength'          => 'maxLength',
        'mode'               => 'mode',
        'multiple'           => 'multiple',
        'options'            => 'options',
        'placeholder'        => 'placeholder',
        'print'              => 'print',
        'required'           => 'required',
        'statField'          => 'statField',
        'tableViewMode'      => 'tableViewMode',
        'unit'               => 'unit',
        'upper'              => 'upper',
        'verticalPrint'      => 'verticalPrint',
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
        if (null !== $this->addressModel) {
            $res['addressModel'] = $this->addressModel;
        }
        if (null !== $this->align) {
            $res['align'] = $this->align;
        }
        if (null !== $this->asyncCondition) {
            $res['asyncCondition'] = $this->asyncCondition;
        }
        if (null !== $this->availableTemplates) {
            $res['availableTemplates'] = [];
            if (null !== $this->availableTemplates && \is_array($this->availableTemplates)) {
                $n = 0;
                foreach ($this->availableTemplates as $item) {
                    $res['availableTemplates'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->bizAlias) {
            $res['bizAlias'] = $this->bizAlias;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->choice) {
            $res['choice'] = $this->choice;
        }
        if (null !== $this->commonBizType) {
            $res['commonBizType'] = $this->commonBizType;
        }
        if (null !== $this->componentId) {
            $res['componentId'] = $this->componentId;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->dataSource) {
            $res['dataSource'] = null !== $this->dataSource ? $this->dataSource->toMap() : null;
        }
        if (null !== $this->disabled) {
            $res['disabled'] = $this->disabled;
        }
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->format) {
            $res['format'] = $this->format;
        }
        if (null !== $this->formula) {
            $res['formula'] = $this->formula;
        }
        if (null !== $this->invisible) {
            $res['invisible'] = $this->invisible;
        }
        if (null !== $this->label) {
            $res['label'] = $this->label;
        }
        if (null !== $this->limit) {
            $res['limit'] = $this->limit;
        }
        if (null !== $this->link) {
            $res['link'] = $this->link;
        }
        if (null !== $this->maxLength) {
            $res['maxLength'] = $this->maxLength;
        }
        if (null !== $this->mode) {
            $res['mode'] = $this->mode;
        }
        if (null !== $this->multiple) {
            $res['multiple'] = $this->multiple;
        }
        if (null !== $this->options) {
            $res['options'] = [];
            if (null !== $this->options && \is_array($this->options)) {
                $n = 0;
                foreach ($this->options as $item) {
                    $res['options'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->placeholder) {
            $res['placeholder'] = $this->placeholder;
        }
        if (null !== $this->print) {
            $res['print'] = $this->print;
        }
        if (null !== $this->required) {
            $res['required'] = $this->required;
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
        if (null !== $this->tableViewMode) {
            $res['tableViewMode'] = $this->tableViewMode;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }
        if (null !== $this->upper) {
            $res['upper'] = $this->upper;
        }
        if (null !== $this->verticalPrint) {
            $res['verticalPrint'] = $this->verticalPrint;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return FormComponentProps
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionName'])) {
            $model->actionName = $map['actionName'];
        }
        if (isset($map['addressModel'])) {
            $model->addressModel = $map['addressModel'];
        }
        if (isset($map['align'])) {
            $model->align = $map['align'];
        }
        if (isset($map['asyncCondition'])) {
            $model->asyncCondition = $map['asyncCondition'];
        }
        if (isset($map['availableTemplates'])) {
            if (!empty($map['availableTemplates'])) {
                $model->availableTemplates = [];
                $n                         = 0;
                foreach ($map['availableTemplates'] as $item) {
                    $model->availableTemplates[$n++] = null !== $item ? AvaliableTemplate::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['bizAlias'])) {
            $model->bizAlias = $map['bizAlias'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['choice'])) {
            $model->choice = $map['choice'];
        }
        if (isset($map['commonBizType'])) {
            $model->commonBizType = $map['commonBizType'];
        }
        if (isset($map['componentId'])) {
            $model->componentId = $map['componentId'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['dataSource'])) {
            $model->dataSource = FormDataSource::fromMap($map['dataSource']);
        }
        if (isset($map['disabled'])) {
            $model->disabled = $map['disabled'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['format'])) {
            $model->format = $map['format'];
        }
        if (isset($map['formula'])) {
            $model->formula = $map['formula'];
        }
        if (isset($map['invisible'])) {
            $model->invisible = $map['invisible'];
        }
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['limit'])) {
            $model->limit = $map['limit'];
        }
        if (isset($map['link'])) {
            $model->link = $map['link'];
        }
        if (isset($map['maxLength'])) {
            $model->maxLength = $map['maxLength'];
        }
        if (isset($map['mode'])) {
            $model->mode = $map['mode'];
        }
        if (isset($map['multiple'])) {
            $model->multiple = $map['multiple'];
        }
        if (isset($map['options'])) {
            if (!empty($map['options'])) {
                $model->options = [];
                $n              = 0;
                foreach ($map['options'] as $item) {
                    $model->options[$n++] = null !== $item ? SelectOption::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['placeholder'])) {
            $model->placeholder = $map['placeholder'];
        }
        if (isset($map['print'])) {
            $model->print = $map['print'];
        }
        if (isset($map['required'])) {
            $model->required = $map['required'];
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
        if (isset($map['tableViewMode'])) {
            $model->tableViewMode = $map['tableViewMode'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['upper'])) {
            $model->upper = $map['upper'];
        }
        if (isset($map['verticalPrint'])) {
            $model->verticalPrint = $map['verticalPrint'];
        }

        return $model;
    }
}
