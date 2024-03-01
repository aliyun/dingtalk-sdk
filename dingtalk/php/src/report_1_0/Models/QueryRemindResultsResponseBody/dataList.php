<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\QueryRemindResultsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\QueryRemindResultsResponseBody\dataList\toGroups;
use AlibabaCloud\Tea\Model;

class dataList extends Model
{
    /**
     * @example user123
     *
     * @var string
     */
    public $creatorId;

    /**
     * @var string[]
     */
    public $endDateTime;

    /**
     * @example 18xxxx
     *
     * @var string
     */
    public $modifierId;

    /**
     * @example 1
     *
     * @var int
     */
    public $periodType;

    /**
     * @var int
     */
    public $remindId;

    /**
     * @var string[]
     */
    public $startDateTime;

    /**
     * @example 123456
     *
     * @var string
     */
    public $templateId;

    /**
     * @var toGroups[]
     */
    public $toGroups;
    protected $_name = [
        'creatorId'     => 'creatorId',
        'endDateTime'   => 'endDateTime',
        'modifierId'    => 'modifierId',
        'periodType'    => 'periodType',
        'remindId'      => 'remindId',
        'startDateTime' => 'startDateTime',
        'templateId'    => 'templateId',
        'toGroups'      => 'toGroups',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->endDateTime) {
            $res['endDateTime'] = $this->endDateTime;
        }
        if (null !== $this->modifierId) {
            $res['modifierId'] = $this->modifierId;
        }
        if (null !== $this->periodType) {
            $res['periodType'] = $this->periodType;
        }
        if (null !== $this->remindId) {
            $res['remindId'] = $this->remindId;
        }
        if (null !== $this->startDateTime) {
            $res['startDateTime'] = $this->startDateTime;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->toGroups) {
            $res['toGroups'] = [];
            if (null !== $this->toGroups && \is_array($this->toGroups)) {
                $n = 0;
                foreach ($this->toGroups as $item) {
                    $res['toGroups'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dataList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['endDateTime'])) {
            if (!empty($map['endDateTime'])) {
                $model->endDateTime = $map['endDateTime'];
            }
        }
        if (isset($map['modifierId'])) {
            $model->modifierId = $map['modifierId'];
        }
        if (isset($map['periodType'])) {
            $model->periodType = $map['periodType'];
        }
        if (isset($map['remindId'])) {
            $model->remindId = $map['remindId'];
        }
        if (isset($map['startDateTime'])) {
            if (!empty($map['startDateTime'])) {
                $model->startDateTime = $map['startDateTime'];
            }
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['toGroups'])) {
            if (!empty($map['toGroups'])) {
                $model->toGroups = [];
                $n               = 0;
                foreach ($map['toGroups'] as $item) {
                    $model->toGroups[$n++] = null !== $item ? toGroups::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
