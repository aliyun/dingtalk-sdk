<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\AnalyzeSubjectTransactionRiskResponseBody\result;

use AlibabaCloud\Tea\Model;

class subjectInfo extends Model
{
    /**
     * @var string
     */
    public $creditCode;

    /**
     * @var string[]
     */
    public $relatedOwnSubjects;

    /**
     * @var string
     */
    public $subjectName;

    /**
     * @var string[]
     */
    public $subjectTags;

    /**
     * @var string
     */
    public $uniqueCode;
    protected $_name = [
        'creditCode' => 'creditCode',
        'relatedOwnSubjects' => 'relatedOwnSubjects',
        'subjectName' => 'subjectName',
        'subjectTags' => 'subjectTags',
        'uniqueCode' => 'uniqueCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->creditCode) {
            $res['creditCode'] = $this->creditCode;
        }
        if (null !== $this->relatedOwnSubjects) {
            $res['relatedOwnSubjects'] = $this->relatedOwnSubjects;
        }
        if (null !== $this->subjectName) {
            $res['subjectName'] = $this->subjectName;
        }
        if (null !== $this->subjectTags) {
            $res['subjectTags'] = $this->subjectTags;
        }
        if (null !== $this->uniqueCode) {
            $res['uniqueCode'] = $this->uniqueCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subjectInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creditCode'])) {
            $model->creditCode = $map['creditCode'];
        }
        if (isset($map['relatedOwnSubjects'])) {
            if (!empty($map['relatedOwnSubjects'])) {
                $model->relatedOwnSubjects = $map['relatedOwnSubjects'];
            }
        }
        if (isset($map['subjectName'])) {
            $model->subjectName = $map['subjectName'];
        }
        if (isset($map['subjectTags'])) {
            if (!empty($map['subjectTags'])) {
                $model->subjectTags = $map['subjectTags'];
            }
        }
        if (isset($map['uniqueCode'])) {
            $model->uniqueCode = $map['uniqueCode'];
        }

        return $model;
    }
}
