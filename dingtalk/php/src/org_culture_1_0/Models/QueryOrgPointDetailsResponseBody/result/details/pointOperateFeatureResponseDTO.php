<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryOrgPointDetailsResponseBody\result\details;

use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryOrgPointDetailsResponseBody\result\details\pointOperateFeatureResponseDTO\accountSource;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryOrgPointDetailsResponseBody\result\details\pointOperateFeatureResponseDTO\accountTarget;
use AlibabaCloud\Tea\Model;

class pointOperateFeatureResponseDTO extends Model
{
    /**
     * @description 如果是扣减操作明细，为被扣减账户
     * 如果是个人积分明细，为来源账户
     * @var accountSource
     */
    public $accountSource;

    /**
     * @description 如果是扣减操作明细，为操作扣减账户
     * 如果是个人积分明细，为目标账户
     * @var accountTarget
     */
    public $accountTarget;

    /**
     * @description 备注信息，在明细中展示
     *
     * @var string
     */
    public $remark;

    /**
     * @description 来源/用途 一般是系统固定的场景
     *
     * @var string
     */
    public $usage;
    protected $_name = [
        'accountSource' => 'accountSource',
        'accountTarget' => 'accountTarget',
        'remark'        => 'remark',
        'usage'         => 'usage',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountSource) {
            $res['accountSource'] = null !== $this->accountSource ? $this->accountSource->toMap() : null;
        }
        if (null !== $this->accountTarget) {
            $res['accountTarget'] = null !== $this->accountTarget ? $this->accountTarget->toMap() : null;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->usage) {
            $res['usage'] = $this->usage;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return pointOperateFeatureResponseDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountSource'])) {
            $model->accountSource = accountSource::fromMap($map['accountSource']);
        }
        if (isset($map['accountTarget'])) {
            $model->accountTarget = accountTarget::fromMap($map['accountTarget']);
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['usage'])) {
            $model->usage = $map['usage'];
        }

        return $model;
    }
}
