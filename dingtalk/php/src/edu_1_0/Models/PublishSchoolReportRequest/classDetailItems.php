<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PublishSchoolReportRequest;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PublishSchoolReportRequest\classDetailItems\studentDetailList;
use AlibabaCloud\Tea\Model;

class classDetailItems extends Model
{
    /**
     * @var string
     */
    public $classId;

    /**
     * @var string
     */
    public $className;

    /**
     * @var studentDetailList[]
     */
    public $studentDetailList;
    protected $_name = [
        'classId'           => 'classId',
        'className'         => 'className',
        'studentDetailList' => 'studentDetailList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->className) {
            $res['className'] = $this->className;
        }
        if (null !== $this->studentDetailList) {
            $res['studentDetailList'] = [];
            if (null !== $this->studentDetailList && \is_array($this->studentDetailList)) {
                $n = 0;
                foreach ($this->studentDetailList as $item) {
                    $res['studentDetailList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return classDetailItems
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['className'])) {
            $model->className = $map['className'];
        }
        if (isset($map['studentDetailList'])) {
            if (!empty($map['studentDetailList'])) {
                $model->studentDetailList = [];
                $n                        = 0;
                foreach ($map['studentDetailList'] as $item) {
                    $model->studentDetailList[$n++] = null !== $item ? studentDetailList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
