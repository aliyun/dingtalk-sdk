<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ListOrgTextEmotionResponseBody\result;

use AlibabaCloud\Tea\Model;

class emotions extends Model
{
    /**
     * @example @234xxx
     *
     * @var string
     */
    public $backgroundMediaId;

    /**
     * @example @123xxx
     *
     * @var string
     */
    public $backgroundMediaIdForPanel;

    /**
     * @example -1
     *
     * @var int
     */
    public $deptId;

    /**
     * @example corp_131xxx
     *
     * @var string
     */
    public $emotionId;

    /**
     * @example 企业表情1
     *
     * @var string
     */
    public $emotionName;

    /**
     * @example 1
     *
     * @var int
     */
    public $status;
    protected $_name = [
        'backgroundMediaId' => 'backgroundMediaId',
        'backgroundMediaIdForPanel' => 'backgroundMediaIdForPanel',
        'deptId' => 'deptId',
        'emotionId' => 'emotionId',
        'emotionName' => 'emotionName',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->backgroundMediaId) {
            $res['backgroundMediaId'] = $this->backgroundMediaId;
        }
        if (null !== $this->backgroundMediaIdForPanel) {
            $res['backgroundMediaIdForPanel'] = $this->backgroundMediaIdForPanel;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->emotionId) {
            $res['emotionId'] = $this->emotionId;
        }
        if (null !== $this->emotionName) {
            $res['emotionName'] = $this->emotionName;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return emotions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['backgroundMediaId'])) {
            $model->backgroundMediaId = $map['backgroundMediaId'];
        }
        if (isset($map['backgroundMediaIdForPanel'])) {
            $model->backgroundMediaIdForPanel = $map['backgroundMediaIdForPanel'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['emotionId'])) {
            $model->emotionId = $map['emotionId'];
        }
        if (isset($map['emotionName'])) {
            $model->emotionName = $map['emotionName'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
