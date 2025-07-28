<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\BatchUpdateExternalTitleResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\BatchUpdateExternalTitleResponseBody\result\failedList;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\BatchUpdateExternalTitleResponseBody\result\modifyList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var failedList[]
     */
    public $failedList;

    /**
     * @var modifyList[]
     */
    public $modifyList;

    /**
     * @var string
     */
    public $modifyUser;
    protected $_name = [
        'failedList' => 'failedList',
        'modifyList' => 'modifyList',
        'modifyUser' => 'modifyUser',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->failedList) {
            $res['failedList'] = [];
            if (null !== $this->failedList && \is_array($this->failedList)) {
                $n = 0;
                foreach ($this->failedList as $item) {
                    $res['failedList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->modifyList) {
            $res['modifyList'] = [];
            if (null !== $this->modifyList && \is_array($this->modifyList)) {
                $n = 0;
                foreach ($this->modifyList as $item) {
                    $res['modifyList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->modifyUser) {
            $res['modifyUser'] = $this->modifyUser;
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
        if (isset($map['failedList'])) {
            if (!empty($map['failedList'])) {
                $model->failedList = [];
                $n = 0;
                foreach ($map['failedList'] as $item) {
                    $model->failedList[$n++] = null !== $item ? failedList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['modifyList'])) {
            if (!empty($map['modifyList'])) {
                $model->modifyList = [];
                $n = 0;
                foreach ($map['modifyList'] as $item) {
                    $model->modifyList[$n++] = null !== $item ? modifyList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['modifyUser'])) {
            $model->modifyUser = $map['modifyUser'];
        }

        return $model;
    }
}
