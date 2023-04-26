<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskInvolveMembersResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskInvolveMembersResponseBody\result\involvers;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var involvers[]
     */
    public $involvers;

    /**
     * @example 2022-06-13T05:33:42.826Z
     *
     * @var string
     */
    public $updated;
    protected $_name = [
        'involvers' => 'involvers',
        'updated'   => 'updated',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->involvers) {
            $res['involvers'] = [];
            if (null !== $this->involvers && \is_array($this->involvers)) {
                $n = 0;
                foreach ($this->involvers as $item) {
                    $res['involvers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->updated) {
            $res['updated'] = $this->updated;
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
        if (isset($map['involvers'])) {
            if (!empty($map['involvers'])) {
                $model->involvers = [];
                $n                = 0;
                foreach ($map['involvers'] as $item) {
                    $model->involvers[$n++] = null !== $item ? involvers::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }

        return $model;
    }
}
