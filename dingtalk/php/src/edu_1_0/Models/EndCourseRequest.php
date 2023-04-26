<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EndCourseRequest\livePlayInfoList;
use AlibabaCloud\Tea\Model;

class EndCourseRequest extends Model
{
    /**
     * @example testCourseCode
     *
     * @var string
     */
    public $courseCode;

    /**
     * @example extData
     *
     * @var string
     */
    public $ext;

    /**
     * @example DDIsv
     *
     * @var string
     */
    public $isvCode;

    /**
     * @var livePlayInfoList[]
     */
    public $livePlayInfoList;

    /**
     * @example 1
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'courseCode'       => 'courseCode',
        'ext'              => 'ext',
        'isvCode'          => 'isvCode',
        'livePlayInfoList' => 'livePlayInfoList',
        'opUserId'         => 'opUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->courseCode) {
            $res['courseCode'] = $this->courseCode;
        }
        if (null !== $this->ext) {
            $res['ext'] = $this->ext;
        }
        if (null !== $this->isvCode) {
            $res['isvCode'] = $this->isvCode;
        }
        if (null !== $this->livePlayInfoList) {
            $res['livePlayInfoList'] = [];
            if (null !== $this->livePlayInfoList && \is_array($this->livePlayInfoList)) {
                $n = 0;
                foreach ($this->livePlayInfoList as $item) {
                    $res['livePlayInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EndCourseRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['courseCode'])) {
            $model->courseCode = $map['courseCode'];
        }
        if (isset($map['ext'])) {
            $model->ext = $map['ext'];
        }
        if (isset($map['isvCode'])) {
            $model->isvCode = $map['isvCode'];
        }
        if (isset($map['livePlayInfoList'])) {
            if (!empty($map['livePlayInfoList'])) {
                $model->livePlayInfoList = [];
                $n                       = 0;
                foreach ($map['livePlayInfoList'] as $item) {
                    $model->livePlayInfoList[$n++] = null !== $item ? livePlayInfoList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
