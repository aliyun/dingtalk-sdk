<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryAllSubjectsFromClassScheduleResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryAllSubjectsFromClassScheduleResponseBody\result\ext;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 创建者orgId
     *
     * @var int
     */
    public $creatorOrgId;

    /**
     * @var ext
     */
    public $ext;

    /**
     * @example HIGH_SCHOOL
     *
     * @var string
     */
    public $periodCode;

    /**
     * @example cn_yuwen
     *
     * @var string
     */
    public $subjectCode;

    /**
     * @example 语文
     *
     * @var string
     */
    public $subjectName;
    protected $_name = [
        'creatorOrgId' => 'creatorOrgId',
        'ext' => 'ext',
        'periodCode' => 'periodCode',
        'subjectCode' => 'subjectCode',
        'subjectName' => 'subjectName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorOrgId) {
            $res['creatorOrgId'] = $this->creatorOrgId;
        }
        if (null !== $this->ext) {
            $res['ext'] = null !== $this->ext ? $this->ext->toMap() : null;
        }
        if (null !== $this->periodCode) {
            $res['periodCode'] = $this->periodCode;
        }
        if (null !== $this->subjectCode) {
            $res['subjectCode'] = $this->subjectCode;
        }
        if (null !== $this->subjectName) {
            $res['subjectName'] = $this->subjectName;
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
        if (isset($map['creatorOrgId'])) {
            $model->creatorOrgId = $map['creatorOrgId'];
        }
        if (isset($map['ext'])) {
            $model->ext = ext::fromMap($map['ext']);
        }
        if (isset($map['periodCode'])) {
            $model->periodCode = $map['periodCode'];
        }
        if (isset($map['subjectCode'])) {
            $model->subjectCode = $map['subjectCode'];
        }
        if (isset($map['subjectName'])) {
            $model->subjectName = $map['subjectName'];
        }

        return $model;
    }
}
