<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchGetGroupSetConfigRequest extends Model
{
    /**
     * @description 配置项key列表
     *
     * @var string[]
     */
    public $configKeys;

    /**
     * @description 开放群组id
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @description 开放团队id
     *
     * @var string
     */
    public $openTeamId;
    protected $_name = [
        'configKeys'     => 'configKeys',
        'openGroupSetId' => 'openGroupSetId',
        'openTeamId'     => 'openTeamId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->configKeys) {
            $res['configKeys'] = $this->configKeys;
        }
        if (null !== $this->openGroupSetId) {
            $res['openGroupSetId'] = $this->openGroupSetId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchGetGroupSetConfigRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['configKeys'])) {
            if (!empty($map['configKeys'])) {
                $model->configKeys = $map['configKeys'];
            }
        }
        if (isset($map['openGroupSetId'])) {
            $model->openGroupSetId = $map['openGroupSetId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }

        return $model;
    }
}
