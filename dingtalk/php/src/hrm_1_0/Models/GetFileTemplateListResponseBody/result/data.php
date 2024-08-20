<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\GetFileTemplateListResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\GetFileTemplateListResponseBody\result\data\attachmentList;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\GetFileTemplateListResponseBody\result\data\fieldList;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\GetFileTemplateListResponseBody\result\data\groupList;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var attachmentList[]
     */
    public $attachmentList;

    /**
     * @example ding57935b18bfd13e9735c2f4657eb6378f
     *
     * @var string
     */
    public $corpId;

    /**
     * @var fieldList[]
     */
    public $fieldList;

    /**
     * @var groupList[]
     */
    public $groupList;

    /**
     * @example f3ed5402e3024febaed773b3ac19feb3
     *
     * @var string
     */
    public $templateId;

    /**
     * @var string
     */
    public $templateInstName;

    /**
     * @example 劳动合同模板
     *
     * @var string
     */
    public $templateName;

    /**
     * @example 1
     *
     * @var int
     */
    public $templateSignStatus;

    /**
     * @example 1
     *
     * @var int
     */
    public $templateStatus;

    /**
     * @var string
     */
    public $templateType;

    /**
     * @example 24
     *
     * @var int
     */
    public $tenantId;
    protected $_name = [
        'attachmentList'     => 'attachmentList',
        'corpId'             => 'corpId',
        'fieldList'          => 'fieldList',
        'groupList'          => 'groupList',
        'templateId'         => 'templateId',
        'templateInstName'   => 'templateInstName',
        'templateName'       => 'templateName',
        'templateSignStatus' => 'templateSignStatus',
        'templateStatus'     => 'templateStatus',
        'templateType'       => 'templateType',
        'tenantId'           => 'tenantId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attachmentList) {
            $res['attachmentList'] = [];
            if (null !== $this->attachmentList && \is_array($this->attachmentList)) {
                $n = 0;
                foreach ($this->attachmentList as $item) {
                    $res['attachmentList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->fieldList) {
            $res['fieldList'] = [];
            if (null !== $this->fieldList && \is_array($this->fieldList)) {
                $n = 0;
                foreach ($this->fieldList as $item) {
                    $res['fieldList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->groupList) {
            $res['groupList'] = [];
            if (null !== $this->groupList && \is_array($this->groupList)) {
                $n = 0;
                foreach ($this->groupList as $item) {
                    $res['groupList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->templateInstName) {
            $res['templateInstName'] = $this->templateInstName;
        }
        if (null !== $this->templateName) {
            $res['templateName'] = $this->templateName;
        }
        if (null !== $this->templateSignStatus) {
            $res['templateSignStatus'] = $this->templateSignStatus;
        }
        if (null !== $this->templateStatus) {
            $res['templateStatus'] = $this->templateStatus;
        }
        if (null !== $this->templateType) {
            $res['templateType'] = $this->templateType;
        }
        if (null !== $this->tenantId) {
            $res['tenantId'] = $this->tenantId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attachmentList'])) {
            if (!empty($map['attachmentList'])) {
                $model->attachmentList = [];
                $n                     = 0;
                foreach ($map['attachmentList'] as $item) {
                    $model->attachmentList[$n++] = null !== $item ? attachmentList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['fieldList'])) {
            if (!empty($map['fieldList'])) {
                $model->fieldList = [];
                $n                = 0;
                foreach ($map['fieldList'] as $item) {
                    $model->fieldList[$n++] = null !== $item ? fieldList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['groupList'])) {
            if (!empty($map['groupList'])) {
                $model->groupList = [];
                $n                = 0;
                foreach ($map['groupList'] as $item) {
                    $model->groupList[$n++] = null !== $item ? groupList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['templateInstName'])) {
            $model->templateInstName = $map['templateInstName'];
        }
        if (isset($map['templateName'])) {
            $model->templateName = $map['templateName'];
        }
        if (isset($map['templateSignStatus'])) {
            $model->templateSignStatus = $map['templateSignStatus'];
        }
        if (isset($map['templateStatus'])) {
            $model->templateStatus = $map['templateStatus'];
        }
        if (isset($map['templateType'])) {
            $model->templateType = $map['templateType'];
        }
        if (isset($map['tenantId'])) {
            $model->tenantId = $map['tenantId'];
        }

        return $model;
    }
}
