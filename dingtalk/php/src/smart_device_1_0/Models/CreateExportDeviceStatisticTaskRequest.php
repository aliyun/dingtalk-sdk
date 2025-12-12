<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateExportDeviceStatisticTaskRequest extends Model
{
    /**
     * @var int
     */
    public $aiSheetTemplateId;

    /**
     * @var string
     */
    public $creatorCorpId;

    /**
     * @var string
     */
    public $creatorUnionId;

    /**
     * @var string
     */
    public $taskName;
    protected $_name = [
        'aiSheetTemplateId' => 'aiSheetTemplateId',
        'creatorCorpId' => 'creatorCorpId',
        'creatorUnionId' => 'creatorUnionId',
        'taskName' => 'taskName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->aiSheetTemplateId) {
            $res['aiSheetTemplateId'] = $this->aiSheetTemplateId;
        }
        if (null !== $this->creatorCorpId) {
            $res['creatorCorpId'] = $this->creatorCorpId;
        }
        if (null !== $this->creatorUnionId) {
            $res['creatorUnionId'] = $this->creatorUnionId;
        }
        if (null !== $this->taskName) {
            $res['taskName'] = $this->taskName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateExportDeviceStatisticTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['aiSheetTemplateId'])) {
            $model->aiSheetTemplateId = $map['aiSheetTemplateId'];
        }
        if (isset($map['creatorCorpId'])) {
            $model->creatorCorpId = $map['creatorCorpId'];
        }
        if (isset($map['creatorUnionId'])) {
            $model->creatorUnionId = $map['creatorUnionId'];
        }
        if (isset($map['taskName'])) {
            $model->taskName = $map['taskName'];
        }

        return $model;
    }
}
