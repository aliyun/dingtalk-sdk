<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class ProcessHhOemUpdateRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $bindOemApp;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $corpIdList;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $useOemApp;
    protected $_name = [
        'bindOemApp' => 'bindOemApp',
        'corpIdList' => 'corpIdList',
        'useOemApp' => 'useOemApp',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bindOemApp) {
            $res['bindOemApp'] = $this->bindOemApp;
        }
        if (null !== $this->corpIdList) {
            $res['corpIdList'] = $this->corpIdList;
        }
        if (null !== $this->useOemApp) {
            $res['useOemApp'] = $this->useOemApp;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ProcessHhOemUpdateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bindOemApp'])) {
            $model->bindOemApp = $map['bindOemApp'];
        }
        if (isset($map['corpIdList'])) {
            if (!empty($map['corpIdList'])) {
                $model->corpIdList = $map['corpIdList'];
            }
        }
        if (isset($map['useOemApp'])) {
            $model->useOemApp = $map['useOemApp'];
        }

        return $model;
    }
}
