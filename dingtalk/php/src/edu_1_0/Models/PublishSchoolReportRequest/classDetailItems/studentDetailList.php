<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PublishSchoolReportRequest\classDetailItems;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PublishSchoolReportRequest\classDetailItems\studentDetailList\subjectList;
use AlibabaCloud\Tea\Model;

class studentDetailList extends Model
{
    /**
     * @var string
     */
    public $studentId;

    /**
     * @var string
     */
    public $studentName;

    /**
     * @var subjectList[]
     */
    public $subjectList;
    protected $_name = [
        'studentId' => 'studentId',
        'studentName' => 'studentName',
        'subjectList' => 'subjectList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->studentId) {
            $res['studentId'] = $this->studentId;
        }
        if (null !== $this->studentName) {
            $res['studentName'] = $this->studentName;
        }
        if (null !== $this->subjectList) {
            $res['subjectList'] = [];
            if (null !== $this->subjectList && \is_array($this->subjectList)) {
                $n = 0;
                foreach ($this->subjectList as $item) {
                    $res['subjectList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return studentDetailList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['studentId'])) {
            $model->studentId = $map['studentId'];
        }
        if (isset($map['studentName'])) {
            $model->studentName = $map['studentName'];
        }
        if (isset($map['subjectList'])) {
            if (!empty($map['subjectList'])) {
                $model->subjectList = [];
                $n = 0;
                foreach ($map['subjectList'] as $item) {
                    $model->subjectList[$n++] = null !== $item ? subjectList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
