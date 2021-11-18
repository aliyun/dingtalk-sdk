<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\StartCourseRequest\livePlayInfoList;
use AlibabaCloud\Tea\Model;

class StartCourseRequest extends Model
{
    /**
     * @description opUserId
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 拓展字段
     *
     * @var string
     */
    public $ext;

    /**
     * @description 课程编码
     *
     * @var string
     */
    public $courseCode;

    /**
     * @description livePlayInfoList
     *
     * @var livePlayInfoList[]
     */
    public $livePlayInfoList;

    /**
     * @description isvCode
     *
     * @var string
     */
    public $isvCode;
    protected $_name = [
        'opUserId'         => 'opUserId',
        'ext'              => 'ext',
        'courseCode'       => 'courseCode',
        'livePlayInfoList' => 'livePlayInfoList',
        'isvCode'          => 'isvCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->ext) {
            $res['ext'] = $this->ext;
        }
        if (null !== $this->courseCode) {
            $res['courseCode'] = $this->courseCode;
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
        if (null !== $this->isvCode) {
            $res['isvCode'] = $this->isvCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return StartCourseRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['ext'])) {
            $model->ext = $map['ext'];
        }
        if (isset($map['courseCode'])) {
            $model->courseCode = $map['courseCode'];
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
        if (isset($map['isvCode'])) {
            $model->isvCode = $map['isvCode'];
        }

        return $model;
    }
}
