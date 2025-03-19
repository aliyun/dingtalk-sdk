<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\AddCustomSignConfigRequest\signTermFiles;
use AlibabaCloud\Tea\Model;

class AddCustomSignConfigRequest extends Model
{
    /**
     * @var bool
     */
    public $allEffect;

    /**
     * @var bool
     */
    public $canDownload;

    /**
     * @description This parameter is required.
     *
     * @example xxx协议
     *
     * @var string
     */
    public $protocolName;

    /**
     * @var string[]
     */
    public $pushDeptIds;

    /**
     * @var string[]
     */
    public $pushStaffIds;

    /**
     * @description This parameter is required.
     *
     * @var signTermFiles[]
     */
    public $signTermFiles;

    /**
     * @description This parameter is required.
     *
     * @example xxx协议说明
     *
     * @var string
     */
    public $termMessage;

    /**
     * @var string[]
     */
    public $unpushDeptIds;

    /**
     * @var string[]
     */
    public $unpushStaffIds;
    protected $_name = [
        'allEffect' => 'allEffect',
        'canDownload' => 'canDownload',
        'protocolName' => 'protocolName',
        'pushDeptIds' => 'pushDeptIds',
        'pushStaffIds' => 'pushStaffIds',
        'signTermFiles' => 'signTermFiles',
        'termMessage' => 'termMessage',
        'unpushDeptIds' => 'unpushDeptIds',
        'unpushStaffIds' => 'unpushStaffIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->allEffect) {
            $res['allEffect'] = $this->allEffect;
        }
        if (null !== $this->canDownload) {
            $res['canDownload'] = $this->canDownload;
        }
        if (null !== $this->protocolName) {
            $res['protocolName'] = $this->protocolName;
        }
        if (null !== $this->pushDeptIds) {
            $res['pushDeptIds'] = $this->pushDeptIds;
        }
        if (null !== $this->pushStaffIds) {
            $res['pushStaffIds'] = $this->pushStaffIds;
        }
        if (null !== $this->signTermFiles) {
            $res['signTermFiles'] = [];
            if (null !== $this->signTermFiles && \is_array($this->signTermFiles)) {
                $n = 0;
                foreach ($this->signTermFiles as $item) {
                    $res['signTermFiles'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->termMessage) {
            $res['termMessage'] = $this->termMessage;
        }
        if (null !== $this->unpushDeptIds) {
            $res['unpushDeptIds'] = $this->unpushDeptIds;
        }
        if (null !== $this->unpushStaffIds) {
            $res['unpushStaffIds'] = $this->unpushStaffIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddCustomSignConfigRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['allEffect'])) {
            $model->allEffect = $map['allEffect'];
        }
        if (isset($map['canDownload'])) {
            $model->canDownload = $map['canDownload'];
        }
        if (isset($map['protocolName'])) {
            $model->protocolName = $map['protocolName'];
        }
        if (isset($map['pushDeptIds'])) {
            if (!empty($map['pushDeptIds'])) {
                $model->pushDeptIds = $map['pushDeptIds'];
            }
        }
        if (isset($map['pushStaffIds'])) {
            if (!empty($map['pushStaffIds'])) {
                $model->pushStaffIds = $map['pushStaffIds'];
            }
        }
        if (isset($map['signTermFiles'])) {
            if (!empty($map['signTermFiles'])) {
                $model->signTermFiles = [];
                $n = 0;
                foreach ($map['signTermFiles'] as $item) {
                    $model->signTermFiles[$n++] = null !== $item ? signTermFiles::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['termMessage'])) {
            $model->termMessage = $map['termMessage'];
        }
        if (isset($map['unpushDeptIds'])) {
            if (!empty($map['unpushDeptIds'])) {
                $model->unpushDeptIds = $map['unpushDeptIds'];
            }
        }
        if (isset($map['unpushStaffIds'])) {
            if (!empty($map['unpushStaffIds'])) {
                $model->unpushStaffIds = $map['unpushStaffIds'];
            }
        }

        return $model;
    }
}
