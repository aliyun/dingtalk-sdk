<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateUniversityCourseGroupRequest\courserGroupItemModels;
use AlibabaCloud\Tea\Model;

class UpdateUniversityCourseGroupRequest extends Model
{
    /**
     * @description opUserId
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 扩展信息
     *
     * @var string
     */
    public $ext;

    /**
     * @description 课程组编码
     *
     * @var string
     */
    public $courseGroupCode;

    /**
     * @description 课程组介绍
     *
     * @var string
     */
    public $courseGroupIntroduce;

    /**
     * @description 课程组名称
     *
     * @var string
     */
    public $courseGroupName;

    /**
     * @description 课程组详细
     *
     * @var courserGroupItemModels[]
     */
    public $courserGroupItemModels;
    protected $_name = [
        'opUserId'               => 'opUserId',
        'ext'                    => 'ext',
        'courseGroupCode'        => 'courseGroupCode',
        'courseGroupIntroduce'   => 'courseGroupIntroduce',
        'courseGroupName'        => 'courseGroupName',
        'courserGroupItemModels' => 'courserGroupItemModels',
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
        if (null !== $this->courseGroupCode) {
            $res['courseGroupCode'] = $this->courseGroupCode;
        }
        if (null !== $this->courseGroupIntroduce) {
            $res['courseGroupIntroduce'] = $this->courseGroupIntroduce;
        }
        if (null !== $this->courseGroupName) {
            $res['courseGroupName'] = $this->courseGroupName;
        }
        if (null !== $this->courserGroupItemModels) {
            $res['courserGroupItemModels'] = [];
            if (null !== $this->courserGroupItemModels && \is_array($this->courserGroupItemModels)) {
                $n = 0;
                foreach ($this->courserGroupItemModels as $item) {
                    $res['courserGroupItemModels'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateUniversityCourseGroupRequest
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
        if (isset($map['courseGroupCode'])) {
            $model->courseGroupCode = $map['courseGroupCode'];
        }
        if (isset($map['courseGroupIntroduce'])) {
            $model->courseGroupIntroduce = $map['courseGroupIntroduce'];
        }
        if (isset($map['courseGroupName'])) {
            $model->courseGroupName = $map['courseGroupName'];
        }
        if (isset($map['courserGroupItemModels'])) {
            if (!empty($map['courserGroupItemModels'])) {
                $model->courserGroupItemModels = [];
                $n                             = 0;
                foreach ($map['courserGroupItemModels'] as $item) {
                    $model->courserGroupItemModels[$n++] = null !== $item ? courserGroupItemModels::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
