<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\CreateTemplatesRequest\fields;
use AlibabaCloud\Tea\Model;

class CreateTemplatesRequest extends Model
{
    /**
     * @var bool
     */
    public $allowAddReceivers;

    /**
     * @var bool
     */
    public $allowEdit;

    /**
     * @var bool
     */
    public $allowGetLocation;

    /**
     * @var string[]
     */
    public $authDeptIds;

    /**
     * @var string[]
     */
    public $authUserIds;

    /**
     * @description This parameter is required.
     *
     * @example 182942
     *
     * @var string
     */
    public $creator;

    /**
     * @var string[]
     */
    public $defaultReceivedCids;

    /**
     * @var string[]
     */
    public $defaultReceivedMasterLevels;

    /**
     * @var string[]
     */
    public $defaultReceivers;

    /**
     * @description This parameter is required.
     *
     * @var fields[]
     */
    public $fields;

    /**
     * @example https://xxx.jpg
     *
     * @var string
     */
    public $logo;

    /**
     * @example 1000
     *
     * @var int
     */
    public $maxWordCount;

    /**
     * @example 1
     *
     * @var int
     */
    public $minWordCount;

    /**
     * @description This parameter is required.
     *
     * @example 工作日报
     *
     * @var string
     */
    public $name;

    /**
     * @var string[]
     */
    public $templateManagers;
    protected $_name = [
        'allowAddReceivers' => 'allowAddReceivers',
        'allowEdit' => 'allowEdit',
        'allowGetLocation' => 'allowGetLocation',
        'authDeptIds' => 'authDeptIds',
        'authUserIds' => 'authUserIds',
        'creator' => 'creator',
        'defaultReceivedCids' => 'defaultReceivedCids',
        'defaultReceivedMasterLevels' => 'defaultReceivedMasterLevels',
        'defaultReceivers' => 'defaultReceivers',
        'fields' => 'fields',
        'logo' => 'logo',
        'maxWordCount' => 'maxWordCount',
        'minWordCount' => 'minWordCount',
        'name' => 'name',
        'templateManagers' => 'templateManagers',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->allowAddReceivers) {
            $res['allowAddReceivers'] = $this->allowAddReceivers;
        }
        if (null !== $this->allowEdit) {
            $res['allowEdit'] = $this->allowEdit;
        }
        if (null !== $this->allowGetLocation) {
            $res['allowGetLocation'] = $this->allowGetLocation;
        }
        if (null !== $this->authDeptIds) {
            $res['authDeptIds'] = $this->authDeptIds;
        }
        if (null !== $this->authUserIds) {
            $res['authUserIds'] = $this->authUserIds;
        }
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }
        if (null !== $this->defaultReceivedCids) {
            $res['defaultReceivedCids'] = $this->defaultReceivedCids;
        }
        if (null !== $this->defaultReceivedMasterLevels) {
            $res['defaultReceivedMasterLevels'] = $this->defaultReceivedMasterLevels;
        }
        if (null !== $this->defaultReceivers) {
            $res['defaultReceivers'] = $this->defaultReceivers;
        }
        if (null !== $this->fields) {
            $res['fields'] = [];
            if (null !== $this->fields && \is_array($this->fields)) {
                $n = 0;
                foreach ($this->fields as $item) {
                    $res['fields'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->logo) {
            $res['logo'] = $this->logo;
        }
        if (null !== $this->maxWordCount) {
            $res['maxWordCount'] = $this->maxWordCount;
        }
        if (null !== $this->minWordCount) {
            $res['minWordCount'] = $this->minWordCount;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->templateManagers) {
            $res['templateManagers'] = $this->templateManagers;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTemplatesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['allowAddReceivers'])) {
            $model->allowAddReceivers = $map['allowAddReceivers'];
        }
        if (isset($map['allowEdit'])) {
            $model->allowEdit = $map['allowEdit'];
        }
        if (isset($map['allowGetLocation'])) {
            $model->allowGetLocation = $map['allowGetLocation'];
        }
        if (isset($map['authDeptIds'])) {
            if (!empty($map['authDeptIds'])) {
                $model->authDeptIds = $map['authDeptIds'];
            }
        }
        if (isset($map['authUserIds'])) {
            if (!empty($map['authUserIds'])) {
                $model->authUserIds = $map['authUserIds'];
            }
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['defaultReceivedCids'])) {
            if (!empty($map['defaultReceivedCids'])) {
                $model->defaultReceivedCids = $map['defaultReceivedCids'];
            }
        }
        if (isset($map['defaultReceivedMasterLevels'])) {
            if (!empty($map['defaultReceivedMasterLevels'])) {
                $model->defaultReceivedMasterLevels = $map['defaultReceivedMasterLevels'];
            }
        }
        if (isset($map['defaultReceivers'])) {
            if (!empty($map['defaultReceivers'])) {
                $model->defaultReceivers = $map['defaultReceivers'];
            }
        }
        if (isset($map['fields'])) {
            if (!empty($map['fields'])) {
                $model->fields = [];
                $n = 0;
                foreach ($map['fields'] as $item) {
                    $model->fields[$n++] = null !== $item ? fields::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['logo'])) {
            $model->logo = $map['logo'];
        }
        if (isset($map['maxWordCount'])) {
            $model->maxWordCount = $map['maxWordCount'];
        }
        if (isset($map['minWordCount'])) {
            $model->minWordCount = $map['minWordCount'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['templateManagers'])) {
            if (!empty($map['templateManagers'])) {
                $model->templateManagers = $map['templateManagers'];
            }
        }

        return $model;
    }
}
