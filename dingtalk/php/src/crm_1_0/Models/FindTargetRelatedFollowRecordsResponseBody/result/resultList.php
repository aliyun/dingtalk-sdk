<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\FindTargetRelatedFollowRecordsResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\FindTargetRelatedFollowRecordsResponseBody\result\resultList\followContent;
use AlibabaCloud\Tea\Model;

class resultList extends Model
{
    /**
     * @example manager7617
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @var followContent[]
     */
    public $followContent;

    /**
     * @example customerId
     *
     * @var string
     */
    public $followTargetDataId;

    /**
     * @example customer
     *
     * @var string
     */
    public $followTargetType;

    /**
     * @example 1712629910168
     *
     * @var string
     */
    public $gmtCreateMilliseconds;

    /**
     * @example 1712629910168
     *
     * @var string
     */
    public $gmtModifiedMilliseconds;

    /**
     * @example manager7617
     *
     * @var string
     */
    public $modifierUserId;

    /**
     * @example _aFFogIuRrWlL3hLdvbb5w09951712629910
     *
     * @var string
     */
    public $recordInstId;
    protected $_name = [
        'creatorUserId'           => 'creatorUserId',
        'followContent'           => 'followContent',
        'followTargetDataId'      => 'followTargetDataId',
        'followTargetType'        => 'followTargetType',
        'gmtCreateMilliseconds'   => 'gmtCreateMilliseconds',
        'gmtModifiedMilliseconds' => 'gmtModifiedMilliseconds',
        'modifierUserId'          => 'modifierUserId',
        'recordInstId'            => 'recordInstId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->followContent) {
            $res['followContent'] = [];
            if (null !== $this->followContent && \is_array($this->followContent)) {
                $n = 0;
                foreach ($this->followContent as $item) {
                    $res['followContent'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->followTargetDataId) {
            $res['followTargetDataId'] = $this->followTargetDataId;
        }
        if (null !== $this->followTargetType) {
            $res['followTargetType'] = $this->followTargetType;
        }
        if (null !== $this->gmtCreateMilliseconds) {
            $res['gmtCreateMilliseconds'] = $this->gmtCreateMilliseconds;
        }
        if (null !== $this->gmtModifiedMilliseconds) {
            $res['gmtModifiedMilliseconds'] = $this->gmtModifiedMilliseconds;
        }
        if (null !== $this->modifierUserId) {
            $res['modifierUserId'] = $this->modifierUserId;
        }
        if (null !== $this->recordInstId) {
            $res['recordInstId'] = $this->recordInstId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return resultList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['followContent'])) {
            if (!empty($map['followContent'])) {
                $model->followContent = [];
                $n                    = 0;
                foreach ($map['followContent'] as $item) {
                    $model->followContent[$n++] = null !== $item ? followContent::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['followTargetDataId'])) {
            $model->followTargetDataId = $map['followTargetDataId'];
        }
        if (isset($map['followTargetType'])) {
            $model->followTargetType = $map['followTargetType'];
        }
        if (isset($map['gmtCreateMilliseconds'])) {
            $model->gmtCreateMilliseconds = $map['gmtCreateMilliseconds'];
        }
        if (isset($map['gmtModifiedMilliseconds'])) {
            $model->gmtModifiedMilliseconds = $map['gmtModifiedMilliseconds'];
        }
        if (isset($map['modifierUserId'])) {
            $model->modifierUserId = $map['modifierUserId'];
        }
        if (isset($map['recordInstId'])) {
            $model->recordInstId = $map['recordInstId'];
        }

        return $model;
    }
}
